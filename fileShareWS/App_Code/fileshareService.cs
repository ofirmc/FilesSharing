using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using FilesSharing;
using System.Data;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    filesLogic fLogic = new filesLogic();
    public Service () 
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    //Insert client files.
    [WebMethod]
    public void insertFIles(DataSet ds) 
    {
         fLogic.InserFiles(ds);
    }
    //Delete a client files.
    [WebMethod]
    public void DeleteFIles(DataSet ds)
    {
        fLogic.DeleteFiles(ds);
    }

    [WebMethod]
    public DataSet GetSearchResults(DataSet ds, string fileName)
    {
        return fLogic.SearchFiles(ds, fileName);
    }
    
}
