using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml;

namespace FilesSharing
{
    class directory2XmlCollection : CollectionBase
    {
        public void Add(directory2Xml d)
        {
            this.InnerList.Add(d);
        }
        public void Remove(directory2Xml d)
        {
            this.InnerList.Remove(d);
        }
        public directory2Xml this[int index]
        {
            get
            {
                return (directory2Xml)this.InnerList[index];
            }
            set
            {
                this.InnerList[index] = value;
            }
        }

        public void SaveAll2XML(string fileName)
        {
            XmlTextWriter writer = new XmlTextWriter(fileName, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("AllDirectories");
            foreach (directory2Xml d in this.InnerList)
            {
                d.Save2XML(writer);
            }
            writer.WriteEndElement();
            writer.Close();
        }

        public void ReadFromXML(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode node = doc.FirstChild;
            while (node.NodeType != XmlNodeType.Element)
                node = node.NextSibling;

            foreach (XmlNode n in node.ChildNodes)
            {
                if (n.NodeType == XmlNodeType.Element)
                {
                    switch (n.Name)
                    {
                        case "dir":
                            directory2Xml d = new directory2Xml();
                            d.LoadFromXML((XmlElement)n);
                            this.InnerList.Add(d);
                            break;
                    }
                }
            }
            
        }
    }
}
