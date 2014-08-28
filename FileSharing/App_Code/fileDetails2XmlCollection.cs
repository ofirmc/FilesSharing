using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using System.Xml;
using System.Text;


public class fileDetails2XmlCollection : CollectionBase
{
    public void Add(fileDetails2Xml fd)
    {
        this.InnerList.Add(fd);
    }
    public void Remove(fileDetails2Xml fd)
    {
        this.InnerList.Remove(fd);
    }
    public fileDetails2Xml this[int index]
    {
        get
        {
            return (fileDetails2Xml)this.InnerList[index];
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
        writer.WriteStartElement("fileDetails");

        foreach (fileDetails2Xml fd in this.InnerList)
        {
            fd.Save2XML(writer);
        }
        writer.WriteEndElement();
        writer.Close();
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
                        fileDetails2Xml fdXML = new fileDetails2Xml();
                        fdXML.LoadFromXML((XmlElement)n);
                        this.InnerList.Add(fdXML);
                        break;
                }
            }
        }

    }
}
