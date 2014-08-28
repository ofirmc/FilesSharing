using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Soap;
using System.Threading;

namespace FilesSharing
{
    
    public class Communicator
    {
        private Socket socket;
        private NetworkStream netStream;
        private SoapFormatter formatter = new SoapFormatter();
        public event SendObjectDelegate GotObject;
        
        private Thread listenThread;
    

        //Ctor:
        public Communicator(Socket socket)
        {
            this.socket = socket;
            netStream = new NetworkStream(socket);
            listenThread = new Thread(new ThreadStart(listen));
            listenThread.Start();
        }
        //Listenning to incoming object from the other side.
        private void listen()
        {
            object obj = null;
            //While: loop while socket is connected.
            while (socket.Connected)
            {
                try
                {
                    obj = formatter.Deserialize(netStream);
                    if (GotObject != null)
                        GotObject(obj);
                }
                catch { }               
             }
        }
        //Sending the object through formatter.
        public void SentObject(object obj)
        {
            try
            {
                formatter.Serialize(netStream, obj);
            }
            catch { }
        }
        //Disconnecting the socket.
        public void Disconnect()
        {
            netStream.Close();
            listenThread.Abort();
            socket.Disconnect(false);
            socket.Close();          
        }
    }
}
