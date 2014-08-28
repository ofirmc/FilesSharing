using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace FilesSharing
{
    class directory2Xml
    {
        public string dirNameAndPath;

        public directory2Xml()
        {

        }
        public directory2Xml(string _dirnameandpath)
        {
            dirNameAndPath = _dirnameandpath;
        }

        public void LoadFromXML(XmlElement element)
        {
            foreach (XmlNode n in element.ChildNodes)
            {
                switch (n.Name)
                {
                    case "dirNameAndPath": this.dirNameAndPath = n.InnerText;
                        break;
                }
            }
        }
        public void Save2XML(XmlTextWriter writer)
        {
            writer.WriteStartElement("dir");
            writer.WriteElementString("dirNameAndPath", dirNameAndPath);
            writer.WriteEndElement();
        }
        public string getData()
        {
            string data;
            data = dirNameAndPath;
            return data;
        }
    }
}
