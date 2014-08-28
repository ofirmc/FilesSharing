using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using FilesSharing;
using System.Threading;
using System.Collections;
using System.IO;

namespace FilesSharing
{
    public partial class frmServer : Form
    {
        TcpListener listener = new TcpListener(9355);
        Communicator comm;
        ClientManager cm;
        AllClientsCollection clientsCollection = new AllClientsCollection();
        private Thread listenThread;
        public bool flag1 = true;
        public fileShareWS.Service s = new FilesSharing.fileShareWS.Service();

        public frmServer()
        {
            InitializeComponent();
        }

        public void SocketAccept()
        {
            while (flag1)
            {
                cm = new ClientManager(listener.AcceptSocket());
                clientsCollection.Add(cm);
            }
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                flag1 = false;//Stops the while loop on SocketAccept() method.
                listenThread.Abort();
                listener.Stop();

            }
            catch { }
        }

        void cm_Disconect(object sender)
        {
            this.comm.Disconnect();
        }

        private void btnStartListen_Click(object sender, EventArgs e)
        {
            //Start listening to clients.
            listener.Start();
            listenThread = new Thread(new ThreadStart(SocketAccept));
            listenThread.Start();
            lblServStart.Text = "Main server has started...";
        }
    }
}