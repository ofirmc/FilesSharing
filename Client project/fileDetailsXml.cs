using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace FilesSharing
{
    class fileDetailsXml
    {
        public string FileName;
        public string Extension;
        public string FileSize;
        public string UserIP;
        public string FilePath;

        public fileDetailsXml()
        {

        }
        public fileDetailsXml(string fName, string extension, string fSize, string userIP, string fPath)
        {
            FileName = fName;
            Extension = extension;
            FileSize = fSize;
            UserIP = userIP;
            FilePath = fPath;
        }
        public void LoadFromXML(XmlElement element)
        {
            foreach (XmlNode n in element.ChildNodes)
            {
                switch (n.Name)
                {
                    case "FileName": this.FileName = n.InnerText;
                        break;
                    case "Extension": this.Extension = n.InnerText;
                        break;
                    case "FileSize": this.FileSize = n.InnerText;
                        break;
                    case "UserIP": this.UserIP = n.InnerText;
                        break;
                    case "FilePath": this.FilePath = n.InnerText;
                        break;
                }
            }
        }
        public string[] getfileDetailsArr()
        {
            string[] arr = new string[5];
            arr[0] = FileName;
            arr[1] = Extension;
            arr[2] = FileSize;
            arr[4] = UserIP;
            arr[5] = FilePath;
            return arr;
        }       
    }
}
