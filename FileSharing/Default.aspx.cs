using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using FilesSharing;
using System.Net.Sockets;
using System.Threading;
using fileshareWS;
using System.IO;

public partial class _Default : System.Web.UI.Page 
{   
    Service fileshare = new Service();
    string userName;
    fileDetails2XmlCollection fdc2XML;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (this.IsPostBack)
            return;

        lBtnDownloadXML.Visible = false;
        userName = Request.Params["userName"];
        ViewState["Username"] = userName;//Keeping user name for redirecting to SearchHistory page.

        if(userName == null)
            lblMessage.Text = "You are now loged in as Anonymous user.";
        else
            lblMessage.Text = "User: " + userName;
    }
    
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (Session["SignInOK"] != null)
        {                    
            DataSet ds = new DataSet();
            GridVResults.DataSource = fileshare.GetSearchResults(ds, txtSearch.Text);
            GridVResults.DataBind();

            /********Setting the search history XML file.********************************************/
            fdc2XML = new fileDetails2XmlCollection();
            for (int i = 0; i < GridVResults.Rows.Count; i++)
            {
                string fileName = GridVResults.Rows[i].Cells[1].Text;
                string extension = GridVResults.Rows[i].Cells[2].Text;
                string fileSize = GridVResults.Rows[i].Cells[3].Text;
                string userIP = GridVResults.Rows[i].Cells[4].Text;
                string filePath = GridVResults.Rows[i].Cells[5].Text;
                fdc2XML.Add(new fileDetails2Xml(fileName, extension, fileSize, userIP, filePath));
            }
            
            userName = ViewState["Username"].ToString();
            //Saving the XML file to server folder.
            fdc2XML.SaveAll2XML(Server.MapPath("SearchHistoryXMLs\\" + userName + "SearchHistory.xml"));
            /****************************************************************************************/

            lBtnDownloadXML.Visible = true;
        }
        else
            lblMessage.Text = "Only site members are allowed to search files, you have to login first.";        
    }
    
    //This is for downloading only one selected result from GridView.
    protected void GridVResults_SelectedIndexChanged(object sender, EventArgs e)
    {
        string fileDetailsName = GridVResults.SelectedRow.Cells[1].Text + ".xml";

        fdc2XML = new fileDetails2XmlCollection();

        //Getting GridView row details.
        string fileName = GridVResults.SelectedRow.Cells[1].Text;
        string Extension = GridVResults.SelectedRow.Cells[2].Text;
        string fileSize = GridVResults.SelectedRow.Cells[3].Text;
        string userIP = GridVResults.SelectedRow.Cells[4].Text;
        string filePath = GridVResults.SelectedRow.Cells[5].Text;
        
        //Writing GridView details to XML file inside xmlFiles server path.
        fdc2XML.Add(new fileDetails2Xml(fileName, Extension, fileSize, userIP, filePath));
        fdc2XML.SaveAll2XML(Server.MapPath("xmlFiles\\" + fileDetailsName));

        //Get the physical path of the file.
        string fileServerPath = Server.MapPath("xmlFiles\\" + fileDetailsName);
        //Set FileInfo to get the propeties of the file.
        FileInfo file = new FileInfo(fileServerPath);
        //Check if the file exist.
        if (file.Exists)
        {
            //Clear the content of Response.
            Response.ClearContent();

            //Add "attachment; filename=" to force open/save/cancel dialog, to Response header.
            Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);

            //Add the file size to Response header.
            Response.AddHeader("Content-Length", file.Length.ToString());

            //Set the contentType to "application/octet-stream" to allow downloading any type of file.
            Response.ContentType = "application/octet-stream";

            //Write the file
            Response.WriteFile(file.FullName);
            Response.End();
        }
        
    }
    //This is for downloading all the results from GridView.
    protected void lBtnDownloadXML_Click(object sender, EventArgs e)
    {
        //Setting the XML file.
        fdc2XML = new fileDetails2XmlCollection();
        for (int i = 0; i < GridVResults.Rows.Count; i++)
        {    
            string fileName = GridVResults.Rows[i].Cells[1].Text;
            string extension = GridVResults.Rows[i].Cells[2].Text;
            string fileSize = GridVResults.Rows[i].Cells[3].Text;
            string userIP = GridVResults.Rows[i].Cells[4].Text;
            string filePath = GridVResults.Rows[i].Cells[5].Text;
            fdc2XML.Add(new fileDetails2Xml(fileName, extension, fileSize, userIP, filePath));
        }
        //Saving the XML file to server folder.
        fdc2XML.SaveAll2XML(Server.MapPath("xmlFiles\\filesResult.xml"));

        //Get the physical path of the file.
        string fileServerPath = Server.MapPath("xmlFiles\\filesResult.xml");
        //Set FileInfo to get the propeties of the file.
        FileInfo file = new FileInfo(fileServerPath);
        //Check if the file exist.
        if (file.Exists)
        {
            //Clear the content of Response.
            Response.ClearContent();

            //Add "attachment; filename=" to force open/save/cancel dialog, to Response header.
            Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);

            //Add the file size to Response header.
            Response.AddHeader("Content-Length", file.Length.ToString());

            //Set the contentType to "application/octet-stream" to allow downloading any type of file.
            Response.ContentType = "application/octet-stream";

            //Write the file
            Response.WriteFile(file.FullName);
            Response.End();

        }

    }
    protected void lBtnSignout_Click(object sender, EventArgs e)
    {
        //Session is null when user has sign out.
        Session["SignInOK"] = null;
        Response.Redirect("Default.aspx");
    }
    protected void lBtnSearchHistory_Click(object sender, EventArgs e)
    {
        if (ViewState["Username"] != null)
        {
            userName = ViewState["Username"].ToString();
            Response.Redirect(string.Format("SearchHistory.aspx?userName={0}", userName));
        }
        else
            lblMessage.Text = "Only site members are allowed to search files, you have to login first.";
    }
}
