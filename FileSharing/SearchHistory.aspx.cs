using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class SearchHistory : System.Web.UI.Page
{
    string userName;
    fileDetails2XmlCollection fdc2XML;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack)
            return;

        //Get user name.
        string userName = Request.Params["userName"];
        ViewState["Username"] = userName;

        if (userName == null)
            Response.Redirect("Default.aspx");

        
        fdc2XML = new fileDetails2XmlCollection();
        //Read user search history XML file.
        fdc2XML.ReadFromXML(Server.MapPath("SearchHistoryXMLs\\" + userName + "SearchHistory.xml"));
        DataTable dt = new DataTable();
        DataRow dr;

        //Creating DataTable columns.
        dt.TableName = "FileDetails";
        dt.Columns.Add("FileName");
        dt.Columns.Add("Path");
        dt.Columns.Add("Extension");
        dt.Columns.Add("Size");
        dt.Columns.Add("UserIP");

        //Populating file details into DataTable.
        foreach (fileDetails2Xml fdXML in fdc2XML)
        {
            dr = dt.NewRow();
            dr["FileName"] = fdXML.FileName;
            dr["Extension"] = fdXML.Extension;
            dr["Size"] = fdXML.FileSize;
            dr["UserIP"] = fdXML.UserIP;
            dr["Path"] = fdXML.FilePath;
            dt.Rows.Add(dr);
        }
        //Show search history on GridView.
        gridSearchHistory.DataSource = dt;
        gridSearchHistory.DataBind();

    }
    protected void lBtnMailPage_Click(object sender, EventArgs e)
    {
        userName = ViewState["Username"].ToString();
        Response.Redirect(string.Format("Default.aspx?userName={0}", userName));
    }
}
