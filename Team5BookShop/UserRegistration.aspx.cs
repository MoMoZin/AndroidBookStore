using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

public partial class UserRegisteration : System.Web.UI.Page
{
    UserBusinessLogic ub;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed7_Click(object sender, EventArgs e)
    {
        ub = new UserBusinessLogic();
        string user = txtUserName.Text;
        string password = txtPassword.Text;
        bool registrationSuccess = ub.RegisterUser(user, password);
        if (registrationSuccess)
        {
            Response.Redirect("~/Login.aspx");
        }
        else
        {
            Label1.Text = "This user name already taken, please try another user name.";
        }
    }
}