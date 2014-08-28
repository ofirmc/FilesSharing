using System;
using System.Collections.Generic;
using System.Text;

namespace FilesSharing
{
    //Delegate for sending object through serialize.
    public delegate void SendObjectDelegate(object obj);
    //Delegate for each client to search it's own files.returns a FileDataCollection object.
    public delegate FileDataCollection SearchDelegate(object sender, SearchInfo s);
    //Delegate for each client to disconnect himself from the main server.
    public delegate void DisconnectDelegate(object sender);
}
