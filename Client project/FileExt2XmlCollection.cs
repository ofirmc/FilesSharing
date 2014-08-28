using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml;

namespace FilesSharing
{
    class FileExt2XmlCollection : CollectionBase
    {
        public void Add(file_Extension2Xml fe)
        {
            this.InnerList.Add(fe);
        }
        public void Remove(file_Extension2Xml fe)
        {
            this.InnerList.Remove(fe);
        }
        public file_Extension2Xml this[int index]
        {
            get
            {
                return (file_Extension2Xml)this.InnerList[index];
            }
            set
            {
                this.InnerList[index] = value;
            }
        }
        public void SaveAll2Xml(string fileName)
        {
            XmlTextWriter writer = new XmlTextWriter(fileName, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();

            writer.WriteStartElement("AllExtension");
            foreach (file_Extension2Xml fe in this.InnerList)
            {
                fe.Save2Xml(writer);
            }
            writer.WriteEndElement();
            writer.Close();
        }
        public void ReadFromXml(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            
            XmlNode node = doc.FirstChild;
     
            //While node type is of a  differnt type move to the next Sibling.
            while (node.NodeType != XmlNodeType.Element)
                node = node.NextSibling;

            //Now we are in the root element.
            foreach (XmlNode n in node.ChildNodes)
            {
                if (n.NodeType == XmlNodeType.Element)
                //We are in one extension.
                {        
                    switch (n.Name)
                    {                         
                        case "Extension":
                            file_Extension2Xml fe = new file_Extension2Xml();
                            fe.LoadFromXml((XmlElement)n);
                            this.InnerList.Add(fe);
                            break;
                    }
                }
            }
        }
    }
}
