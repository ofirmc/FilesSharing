using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


public class usersLogic
{
    DAL dal = new DAL();
    public usersLogic()
    {

    }

    //function to sign in a new user in the database.
    public void SignInNewUser(string userName, string password, string fName, string lName, string email)
    {
        string sql = string.Format("Insert INTO UsersTable(userNameField,userPasswordField,userFirstName,userLastName,EmailField) VALUES('{0}','{1}','{2}','{3}','{4}')",
            userName, password, fName, lName, email);
        dal.Open();
        dal.ExecuteNonQuery(sql);
        dal.Close();
    }

    //Check if user and password exist in the database.
    public bool IsExist(string userName, string userPassword)
    {
        bool ok = false;
        try
        {
            string sql = "select userPasswordField FROM UsersTable WHERE userNameField = '" + userName + "'";
            dal.Open();
            string password = dal.GetScalar(sql).ToString();
            dal.Close();
            if (userPassword == password)
            {
                ok = true;
            }
        }
        catch { };
        return ok;
    }

    //Check if user name already exist in the data base.
    public bool checkUserExist(string userName)
    {
        bool ok = false;
        try
        {
            string sql = "SELECT userNameField FROM UsersTable WHERE userNameField = '" + userName + "'";
            dal.Open();
            string existinguser = dal.GetScalar(sql).ToString();
            dal.Close();
            if (existinguser == userName)
            {
                ok = true;
            }
        }
        catch
        {
            dal.Close();
        }
        return ok;
    }
}
