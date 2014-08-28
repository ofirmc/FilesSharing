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

public partial class Login_page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack)
            return;  
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        usersLogic uLogic = new usersLogic();
        //Check if the user has signed in the DataBase.
        if(uLogic.IsExist(txtUserName.Text, txtUserPassword.Text))
        {
            Session["SignInOK"] = true;
            Response.Redirect(string.Format("Default.aspx?userName={0}",txtUserName.Text));
        }
        else
            lblLoginError.Text = "Incorrect user name or password.";
    }
    
}
