using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml;


public class fileDetails2Xml
{
    public string FileName;
    public string Extension;
    public string FileSize;
    public string UserIP;
    public string FilePath;

    public fileDetails2Xml()
    {
       
    }
    public fileDetails2Xml(string fName, string extension, string fSize, string userIP, string fPath)
    {
        FileName = fName;
        Extension = extension;
        FileSize = fSize;
        UserIP = userIP;     
        FilePath = fPath;        
    }
    public void Save2XML(XmlTextWriter writer)
    {
        //Creatating a node.
        writer.WriteStartElement("fileDetail");
        writer.WriteElementString("FileName", FileName);
        writer.WriteElementString("Extension", Extension);
        writer.WriteElementString("FileSize", FileSize);       
        writer.WriteElementString("UserIP", UserIP);
        writer.WriteElementString("FilePath", FilePath);
        writer.WriteEndElement();
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
    public string[] InsertfileDetailsArr(string[] arr)
    {
        FileName = arr[0];
        Extension = arr[1];
        FileSize = arr[2];
        UserIP = arr[3];
        FilePath = arr[4];
        return arr;
    }
}
