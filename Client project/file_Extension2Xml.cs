using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace FilesSharing
{
    class file_Extension2Xml
    {
        public string csExtension;
        public string txtExtension;
        public string slnExtension;
        public string suoExtension;
        public string resxExtension;
        public string csprojExtension;
        public string exeExtension;
        public string dllExtension;
        public string pdbExtension;

        public file_Extension2Xml()
        {

        }
        public file_Extension2Xml(string csExt, string txtExt, string slnExt, string suoExt, string resxExt, string csprojExt, string exeExt, string dllExt, string pdbExt)
        {
            csExtension = csExt;
            txtExtension = txtExt;
            slnExtension = slnExt;
            suoExtension = suoExt;
            resxExtension = resxExt;
            csprojExtension = csprojExt;
            exeExtension = exeExt;
            dllExtension = dllExt;
            pdbExtension = pdbExt;
        }
        public override string ToString()
        {
           
            return "csExtension: " + csExtension + " " + "txtExtension :" + txtExtension + " " + "slnExtension :" + " " + slnExtension;
        }
        public string[] getarr()
        {
            string[] arr = new string[9];
            arr[0] = csExtension;
            arr[1] = txtExtension;
            arr[2] = slnExtension;
            arr[3] = suoExtension;
            arr[4] = resxExtension;
            arr[5] = csprojExtension;
            arr[6] = exeExtension;
            arr[7] = dllExtension;
            arr[8] = pdbExtension;
            return arr;
        }

        public void print()
        {
           MessageBox.Show(ToString());
        }

        public void LoadFromXml(XmlElement element)
        {
            foreach (XmlNode n in element.ChildNodes)
            {
                switch (n.Name)
                {

                    case "csExtension": this.csExtension = n.InnerText;
                        break;
                    case "txtExtension": this.txtExtension = n.InnerText;
                        break;
                    case "slnExtension": this.slnExtension = n.InnerText;
                        break;
                    case "suoExtension": this.suoExtension = n.InnerText;
                        break;
                    case "resxExtension": this.resxExtension = n.InnerText;
                        break;
                    case "csprojExtension": this.csprojExtension = n.InnerText;
                        break;
                    case "exeExtension": this.exeExtension = n.InnerText;
                        break;
                    case "dllExtension": this.dllExtension = n.InnerText;
                        break;
                    case "pdbExtension": this.pdbExtension = n.InnerText;
                        break;
                }
            }
        }
        public void Save2Xml(XmlTextWriter writer)
        {
            //Creatating a node.
            writer.WriteStartElement("Extension");
            writer.WriteElementString("csExtension", csExtension);
            writer.WriteElementString("txtExtension", txtExtension);
            writer.WriteElementString("slnExtension", slnExtension);
            writer.WriteElementString("suoExtension", suoExtension);
            writer.WriteElementString("resxExtension", resxExtension);
            writer.WriteElementString("csprojExtension", csprojExtension);
            writer.WriteElementString("exeExtension", exeExtension);
            writer.WriteElementString("dllExtension", dllExtension);
            writer.WriteElementString("pdbExtension", pdbExtension);
            writer.WriteEndElement();

        }
    }
}
