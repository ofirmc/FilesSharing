using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using FilesSharing;
using System.IO;
using System.Threading;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
using Remoting_Dll;

namespace FilesSharing
{
    public partial class frmClient : Form
    {
        FileFetcher fileObj;
        Communicator comm;
        FileDataCollection fdcForServer = new FileDataCollection();
        FileDataCollection fdcForRemoting;
        directory2XmlCollection dCollection;        
        public string[] FileExtensionArr;
        public string[] directoryFiles;
        public string[] filesFromXML;
        private int port = 9355;
        private string ip = "127.0.0.1";
        private bool clientIsConnected = false;
        private bool clbItemCheckedFlag = false;//Set flag.

        public frmClient()
        {
            InitializeComponent();
        }                
            
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Close the client application when tabPage-Close is selected.
            if ((tabControl1.SelectedIndex == 6) && (clientIsConnected == false))
            {
                Application.Exit();
            }
            else if((tabControl1.SelectedIndex == 6) && (clientIsConnected == true))
            {
                try
                {
                    comm.SentObject("Disconnect");
                    comm.Disconnect();
                    lblDisconnectMsg.Text = "Disconnected from server.";
                    clientIsConnected = false;
                    Application.Exit();
                }
                catch { }
            }

            //Load XML.
            if (tabControl1.SelectedIndex == 2)
            {
                //Set openFileDialog file extension filter.
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "All supported types(*.xml)|*.xml|XML files(*.xml)|*.xml";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {                  
                    fileDetailsXmlCollection fdXmlCollection = new fileDetailsXmlCollection();
                    fdXmlCollection.ReadFromXML(openFileDialog1.FileName);
                    this.tabControl1.SelectedIndex = 0;
                    this.tabControl1.TabPages[0].Parent.Focus();
                    lvSerachResult.Items.Clear();
                    foreach (fileDetailsXml fdx in fdXmlCollection)
                    {
                        ListViewItem lvi = new ListViewItem();
                        ListViewItem.ListViewSubItem lvsi1 = new ListViewItem.ListViewSubItem();
                        ListViewItem.ListViewSubItem lvsi2 = new ListViewItem.ListViewSubItem();
                        ListViewItem.ListViewSubItem lvsi3 = new ListViewItem.ListViewSubItem();
                        lvi.Text = fdx.FileName + fdx.Extension;
                        lvsi1.Text = fdx.FileSize;
                        lvsi2.Text = fdx.UserIP;
                        lvsi3.Text = fdx.FilePath + fdx.FileName + fdx.Extension;
                        lvi.SubItems.Add(lvsi1);
                        lvi.SubItems.Add(lvsi2);
                        lvi.SubItems.Add(lvsi3);
                        lvSerachResult.Items.Add(lvi);
                    }
                }
            }

            //Connect the client to the server when tabPage-Connect is selected.
            if (tabControl1.SelectedIndex == 4)
            {
                try
                {
                    TcpClient tcpclient = new TcpClient();
                    tcpclient.Connect(ip, port);
                    lblConnectMsg.Text = "connecting to ip: " + ip + " on port: " + port;
                    comm = new Communicator(tcpclient.Client);
                    comm.GotObject += new SendObjectDelegate(comm_GotObject);
                    comm.SentObject(fdcForServer);
                    clientIsConnected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error!");
                }
            }

            //Disconnect server when tabPage-Disconnect is selected.
            if (tabControl1.SelectedIndex == 5)
            {
                try
                {
                    comm.SentObject("Disconnect");
                    comm.Disconnect();
                    lblDisconnectMsg.Text = "Disconnected from server.";
                    clientIsConnected = false;
                }
                catch { }
            }            
        }

        void comm_GotObject(object obj)
        {
            fdcForRemoting = (FileDataCollection)obj;
            foreach (FileDataToTransfer fd2t in fdcForRemoting)
            {
                //Add the file details into ListView.
                ListViewItem lvi = new ListViewItem();              
                ListViewItem.ListViewSubItem lvsi1 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem lvsi2 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem lvsi3 = new ListViewItem.ListViewSubItem();
                lvi.Text = fd2t.FileName + fd2t.Extension;               
                lvsi1.Text = fd2t.Size.ToString();
                lvsi2.Text = fd2t.IP;
                lvsi3.Text = fd2t.FullName;
                lvi.SubItems.Add(lvsi1);
                lvi.SubItems.Add(lvsi2);
                lvi.SubItems.Add(lvsi3);
                lvSerachResult.Items.Add(lvi);
            }
        }

        private void btnSelectDirectory_Click_1(object sender, EventArgs e)
        {
            //Show the selected directory to share on a label.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                lblShowPath.Text = folderBrowserDialog1.SelectedPath;

            //Running on FileExtensionArr extension collection and adding the corresponded
            //files into string array(string[] files) by searching the files in the directories.
            for (int i = 0; i < FileExtensionArr.Length; i++)
            {
                directoryFiles = Directory.GetFiles(lblShowPath.Text, "*" + FileExtensionArr[i],
                       SearchOption.AllDirectories);
                //Running on the string array and adding each file data into filedataCollection
                //object to send the server when the client decides to connect.
                foreach (string fileName in directoryFiles)
                {
                    Filedata fileData = new Filedata(fileName);
                    fdcForServer.Add(fileData);
                }
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {

            /*******Writing extension files collection to an XML file.********************/
            FileExt2XmlCollection fec = new FileExt2XmlCollection();
            fec.Add(new file_Extension2Xml(".cs", ".txt", ".sln", ".suo", ".resx", ".csproj", ".exe", ".dll", ".pdb"));
            fec.SaveAll2Xml("fileExtensions.xml");
            /*****************************************************************************/



            /***Loading file extension from XML and presenting them on a ChecketListBox***/
            fec.ReadFromXml("fileExtensions.xml");
            foreach (file_Extension2Xml f in fec)
            {
                FileExtensionArr = f.getarr();
            }
            //Add file extension to checkedListBoxExt from FileExtensionArr collection.    
            for (int i = 0; i < FileExtensionArr.Length; i++)
            {
                checkedListBoxExt.Items.Add(FileExtensionArr[i]);
            }
            checkedListBoxExt.Items.Add("Select all");
            /*****************************************************************************/

            /********Loading sharing folder from XML******************************************/
            try
            {
                dCollection = new directory2XmlCollection();
                dCollection.ReadFromXML("Directories.xml");
                foreach (directory2Xml d in dCollection)
                {
                    lblShowPath.Text = d.getData();
                }
            }
            catch { }

            /********Loading downloads folder from XML******************************************/

            dCollection = new directory2XmlCollection();
            dCollection.ReadFromXML("DownloadsDirectory.xml");
            foreach (directory2Xml d in dCollection)
            {
                lblDownloadsPath.Text = d.getData();
            }
            //Checking if downloads folder still exist(if the user did'nt erase it).
            DirectoryInfo di = new DirectoryInfo(lblDownloadsPath.Text);
            if(!di.Exists)
                lblDownloadsPath.Text = "Choose a downloads directory.";
            /*********************************************************************************/

            SearchDirectoryFiles();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Creating array of string the in size of checkedListBoxExt itemes count. 
            string[] checketBoxSelectedArr = new string[checkedListBoxExt.CheckedItems.Count];

            //Copying the selected checket boxes to the string array.
            checkedListBoxExt.CheckedItems.CopyTo(checketBoxSelectedArr, 0);

            try
            {
                SearchInfo searchInfo = new SearchInfo(checketBoxSelectedArr, txtSearch.Text);
                comm.SentObject(searchInfo);
                lvSerachResult.Items.Clear();
            }
            catch { }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Show the selected directory to share on a label.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                lblShowPath.Text = folderBrowserDialog1.SelectedPath;

            /********Writing sharing folder to XML******************************************/
            dCollection = new directory2XmlCollection();
            dCollection.Add(new directory2Xml(lblShowPath.Text));
            dCollection.SaveAll2XML("Directories.xml");
            /*********************************************************************************/

            SearchDirectoryFiles();
        }     

        private void lvSerachResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            string fileAndPath = lvSerachResult.SelectedItems[0].SubItems[3].Text;
            string fileName = lvSerachResult.SelectedItems[0].Text;

            
            try
            {
                //Using remoting to get an object or file from another listening client.
                fileObj = (FileFetcher)Activator.GetObject(typeof(FileFetcher),
                   "tcp://" + lvSerachResult.SelectedItems[0].SubItems[2].Text + ":7655" + "/FetchFile");
  
                string file = fileObj.GetFile(fileAndPath);
                Add2lvDownloads();

                //Writing the file to a folder.
                try
                {
                    StreamWriter writer = new StreamWriter(lblDownloadsPath.Text + "\\" + fileName);
                    writer.Write(file);
                    writer.Close();
                }
                catch { }                             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        //Add the downloading file details to downloads ListView.
        private void Add2lvDownloads()
        {
            ListViewItem lvi = new ListViewItem();
            ListViewItem.ListViewSubItem lvsi1 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem lvsi2 = new ListViewItem.ListViewSubItem();           
            lvi.Text = lvSerachResult.SelectedItems[0].Text;
            lvsi1.Text = lvSerachResult.SelectedItems[0].SubItems[1].Text;
            lvsi2.Text = lvSerachResult.SelectedItems[0].SubItems[2].Text;
            lvi.SubItems.Add(lvsi1);
            lvi.SubItems.Add(lvsi2);
            lvDownloads.Items.Add(lvi);
        }

        //This is for checkedListBox Select all check.
        private void checkedListBoxExt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxExt.SelectedItem.ToString() == "Select all")
            {
                if (clbItemCheckedFlag == false)
                {
                    for (int i = 0; i < checkedListBoxExt.Items.Count; i++)
                    {
                        checkedListBoxExt.SetItemChecked(i, true);
                    }
                    clbItemCheckedFlag = true;
                }
                else if (clbItemCheckedFlag == true)
                {                
                        for (int i = 0; i < checkedListBoxExt.Items.Count; i++)
                        {
                            checkedListBoxExt.SetItemChecked(i, false);
                        }
                        clbItemCheckedFlag = false;                 
                }
            }
        }
        public void SearchDirectoryFiles()
        {
            try
            {
                if (lblShowPath.Text != "Path:")
                {
                    //Running on FileExtensionArr extension collection and adding the corresponded
                    //files into string array(string[] files) by searching the files in the directories.
                    for (int i = 0; i < FileExtensionArr.Length; i++)
                    {
                        directoryFiles = Directory.GetFiles(lblShowPath.Text, "*" + FileExtensionArr[i],
                               SearchOption.AllDirectories);
                        //Running on the string array and adding each file data into filedataCollection
                        //object to send the server when the client decides to connect.
                        foreach (string fileName in directoryFiles)
                        {
                            Filedata fileData = new Filedata(fileName);
                            fdcForServer.Add(fileData);
                        }
                    }
                }
            }
            catch //If a share path does'nt exist(if the user did'nt erase it).
            {
                lblShowPath.Text = "Choose a directory to share.";
                this.tabControl1.SelectedIndex = 3;
                this.tabControl1.TabPages[3].Parent.Focus();
            }
        }

        private void btnBrowseDownloads_Click(object sender, EventArgs e)
        {
            //Show the selected directory to download files.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                lblDownloadsPath.Text = folderBrowserDialog1.SelectedPath;


            /********Writing sharing folder to XML******************************************/
            dCollection = new directory2XmlCollection();
            dCollection.Add(new directory2Xml(lblDownloadsPath.Text));
            dCollection.SaveAll2XML("DownloadsDirectory.xml");
            /*********************************************************************************/
        }     
    }
}