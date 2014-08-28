using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;


public class DAL
{
    private static string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + HttpContext.Current.Server.MapPath("App_Data\\UsersDB.mdb");
    private OleDbConnection connection = new OleDbConnection();
    private OleDbCommand command = new OleDbCommand();
    private OleDbDataAdapter adapter = new OleDbDataAdapter();

    public DAL()
    {
        connection.ConnectionString = ConnectionString;
        command.Connection = connection;
        adapter.SelectCommand = command;
    }
    public void Open()
    {
        connection.Open();
    }
    public void Close()
    {
        connection.Close();
    }
    public object GetScalar(string sql)
    {
        command.CommandType = CommandType.Text;
        command.CommandText = sql;
        return command.ExecuteScalar();
    }
    public DataTable GetTable(string sql)
    {
        DataTable dt = new DataTable();
        command.CommandType = CommandType.Text;
        command.CommandText = sql;
        adapter.Fill(dt);
        return dt;
    }
    public int ExecuteNonQuery(string sql)
    {
        command.CommandType = CommandType.Text;
        command.CommandText = sql;
        return command.ExecuteNonQuery();
    }
}
