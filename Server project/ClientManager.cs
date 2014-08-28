using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Data;
using System.Xml.Serialization;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using FilesSharing;

namespace FilesSharing
{   
    public class ClientManager
    {
        private Communicator comm;
        private string IP;
        private string extractedIP;
        public fileShareWS.Service service = new FilesSharing.fileShareWS.Service();
        private FileDataCollection clientFiles;
        public event SearchDelegate GotSearchRequest;
        public event DisconnectDelegate Disconect;
        DataSet ds = new DataSet();

        public ClientManager(Socket socket)
        {
            comm = new Communicator(socket);
            comm.GotObject += new SendObjectDelegate(comm_GotObject);

            //Getting the client ip from socket.
            IP = socket.RemoteEndPoint.ToString();

            //Extracting the ip from the ip+port.
            extractedIP = IP.Substring(0, IP.LastIndexOf(":"));           
        }

        private void comm_GotObject(object obj)
        {
            ArrayList arrList = new ArrayList();

            if (obj is FileDataCollection)
            {
                clientFiles = (FileDataCollection)obj;
                SendClientFiles2WS();             
            }
            else if (obj is SearchInfo)
            {
                //Populate the search result to a collection.
                FileDataCollection searchResult = GotSearchRequest(this, (SearchInfo)obj);
                comm.SentObject(searchResult);
            }
            else if (obj is string && obj.ToString() == "Disconnect")
            {
                WSDeleteClientFiles();
                //Using disconnect event on AllClientCollection class.
                Disconect(this);
                comm.Disconnect();
            }
        }
        //This function is called from AllClientsClollection class.
        public void SearchInternalFiles(SearchInfo searchInfo, FileDataCollection results)
        {
            string exp = searchInfo.WordToSearch.ToLower();//Preparing the regex expression.
            for (int i = 0; i < searchInfo.Suffixes.Length; i++)
            {
                foreach (Filedata fd in clientFiles)
                {
                    Match m = Regex.Match(fd.FileName.ToLower(), exp);//Matching the expression with file date - file name.
                    if(fd.Extension == searchInfo.Suffixes[i] && m.Success)
                    {
                        FileDataToTransfer fd2t = new FileDataToTransfer(extractedIP, fd);
                        results.Add(fd2t);
                    }                   
                }
            }    
        }
        public void SendClientFiles2WS()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dr;
   
            dt.TableName = "FileDetails";
            dt.Columns.Add("FileName");
            dt.Columns.Add("Path");
            dt.Columns.Add("Extension");
            dt.Columns.Add("Size");
            dt.Columns.Add("UserIP");

            foreach (Filedata fd in clientFiles)
            {
                dr = dt.NewRow();
                dr["FileName"] = fd.FileName;
                dr["Path"] = fd.Path;
                dr["Extension"] = fd.Extension;
                dr["Size"] = fd.Size;
                dr["UserIP"] = extractedIP;
                dt.Rows.Add(dr);
                
            }
            ds.Tables.Add(dt);
            service.insertFIles(ds);//Sending the DataSet object to WebService.
        }
        public void WSDeleteClientFiles()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dr;

            dt.TableName = "FileDetails";
            dt.Columns.Add("FileName");
            dt.Columns.Add("Path");
            dt.Columns.Add("Extension");
            dt.Columns.Add("Size");
            dt.Columns.Add("UserIP");

            foreach (Filedata fd in clientFiles)
            {
                dr = dt.NewRow();
                dr["FileName"] = fd.FileName;
                dr["Path"] = fd.Path;
                dr["Extension"] = fd.Extension;
                dr["Size"] = fd.Size;
                dr["UserIP"] = extractedIP;
                dt.Rows.Add(dr);

            }
            ds.Tables.Add(dt);
            service.DeleteFIles(ds);//Sending the DataSet object to WebService.
        }
    }
}
