using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
using Remoting_Dll;

#pragma warning disable 618

namespace FilesSharing
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Remoting listen side on the client.
            try
            {
                ChannelServices.RegisterChannel(new TcpChannel(7655));
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(FileFetcher),
                    "FetchFile", WellKnownObjectMode.SingleCall);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmClient());            
        }
    }
}