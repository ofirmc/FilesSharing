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

public class filesLogic
{
    public DAL dal = new DAL();
    public filesLogic()
    {

    }

    //Search files inside the  DataBase.
    public DataSet SearchFiles(DataSet ds, string fileName)
    {
        string sql = "SELECT fileName, Extension, fileSize, userIP, filePath FROM FileDetails WHERE (fileName LIKE '%" + fileName + "%')";
        dal.Open();
        dal.GetDataset(ds, sql, "FileDetails");
        dal.Close();
        return ds;
    }

    //Inser each client files.
    public void InserFiles(DataSet ds)
    {      
        DataTable dt = ds.Tables["FileDetails"];
        foreach (DataRow row in dt.Rows)
        {           
            string fileName = row["FileName"].ToString();
            string filePath = row["Path"].ToString();
            string extension = row["Extension"].ToString();
            string fileSize = row["Size"].ToString();
            string userIP = row["UserIP"].ToString();

            string sql = "INSERT INTO FileDetails(fileName,Extension,fileSize,userIP,filePath) values('" + fileName + "','" + extension + "','" + fileSize + "','" + userIP + "','" + filePath + "')";
            dal.Open();
            dal.ExecuteNonQuery(sql);
            dal.Close();
        }
    }
    //Delete a client files.
    public void DeleteFiles(DataSet ds)
    {
        DataTable dt = ds.Tables["FileDetails"];
        foreach (DataRow row in dt.Rows)
        {
            string fileName = row["FileName"].ToString();
            string filePath = row["Path"].ToString();
            string extension = row["Extension"].ToString();
            string fileSize = row["Size"].ToString();
            string userIP = row["UserIP"].ToString();

            string sql = "DELETE FROM FileDetails WHERE fileName = '" + fileName + "'";
            dal.Open();
            dal.ExecuteNonQuery(sql);
            dal.Close();
        }
    }
}
