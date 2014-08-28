using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace FilesSharing
{
    [Serializable]
    public class FileDataToTransfer : Filedata
    {
        public string IP;

        public FileDataToTransfer()
        {

        }
        public FileDataToTransfer(string ip, Filedata fData)
        {
            this.FileName = fData.FileName;
            this.Extension = fData.Extension;
            this.Size = fData.Size;
            this.Path = fData.Path;
            this.IP = ip;
        }
    }
}
