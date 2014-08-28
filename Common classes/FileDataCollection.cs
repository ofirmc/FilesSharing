using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace FilesSharing
{
    [Serializable]
    public class FileDataCollection : CollectionBase
    {
        public FileDataCollection()
        {

        }
        public void Add(Filedata fd)
        {
            this.InnerList.Add(fd);
        }
        public void Remove(Filedata fd)
        {
            this.InnerList.Remove(fd);
        }
        public Filedata this[int index]
        {
            get
            {
                return (Filedata)this.InnerList[index];
            }
            set
            {
                this.InnerList[index] = value;
            }
        }
    }
}
