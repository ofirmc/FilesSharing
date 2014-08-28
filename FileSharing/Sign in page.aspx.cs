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

public partial class Sign_in_page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        usersLogic uLogic = new usersLogic();

        if (uLogic.checkUserExist(txtUserName.Text))//Check if a user name exist.
            lblChooseDifferentName.Text = "User name already exist, choose a differnt name.";
        else if(uLogic.checkUserExist(txtUserName.Text) == false)
        {
            lblChooseDifferentName.Text = "";
            uLogic.SignInNewUser(txtUserName.Text, txtUserPassword.Text, txtFirstName.Text,
                txtLastName.Text, txtUserEmail.Text);

            Session["SignInOK"] = true;
            Response.Redirect(string.Format("Default.aspx?userName={0}", txtUserName.Text));
        }

    }
}
