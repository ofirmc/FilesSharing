using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml;

namespace FilesSharing
{
    class fileDetailsXmlCollection : CollectionBase
    {
        public void Add(fileDetailsXml fd)
        {
            this.InnerList.Add(fd);
        }
        public void Remove(fileDetailsXml fd)
        {
            this.InnerList.Remove(fd);
        }
        public fileDetailsXml this[int index]
        {
            get
            {
                return (fileDetailsXml)this.InnerList[index];
            }
            set
            {
                this.InnerList[index] = value;
            }
        }

        public void ReadFromXML(string fileName)
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
                {
                    switch (n.Name)
                    {
                        case "fileDetail":
                            fileDetailsXml fdXML = new fileDetailsXml();
                            fdXML.LoadFromXML((XmlElement)n);
                            this.InnerList.Add(fdXML);
                            break;
                    }
                }
            }
            
        }
    }
}
