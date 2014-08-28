using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace FilesSharing
{
    public class AllClientsCollection : CollectionBase
    {
        public void Add(ClientManager cm)
        {
            //Add for each client GotSearchRequest and Disconect events.
            this.InnerList.Add(cm);
            cm.GotSearchRequest += new SearchDelegate(cm_GotSearchRequest);
            cm.Disconect += new DisconnectDelegate(cm_Disconect);
        }

        void cm_Disconect(object sender)
        {
            Remove((ClientManager)sender);
        }
       
        FileDataCollection cm_GotSearchRequest(object sender, SearchInfo s)
        {
            FileDataCollection results = new FileDataCollection();
            ClientManager c = (ClientManager)sender;
            foreach (ClientManager cm in this.InnerList)
            {
                //If the client is not the one who sent the search request, do the search.
                if(cm != c)
                    cm.SearchInternalFiles(s, results);
            }
            return results;
        }
        public void Remove(ClientManager cm)
        {
            this.InnerList.Remove(cm);
        }
        public ClientManager this[int index]
        {
            get
            {
                return (ClientManager)this.InnerList[index];
            }
            set
            {
                this.InnerList[index] = value;
            }
        }
        
    }
}
