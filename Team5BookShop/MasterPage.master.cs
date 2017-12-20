using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Session["SearchItem"] = txtSearch.Value.ToString();
        Response.Redirect("~/SearchResult.aspx");        
    }

    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Login.aspx");
    }

    protected void btnSignOut_Click(object sender, EventArgs e)
    {
        Session["userId"] = null;
        Session["userType"] = null;
        Session["ShoppingCartObj"] = new ShoppingCart();
        Response.Redirect("~/Main.aspx");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ShoppingCart shpcrt = (ShoppingCart)Session["ShoppingCartObj"];
        btnCart.Text = "Shopping Cart | " + shpcrt.Cart.Count.ToString();
        if (Session["userId"] == null)
        {
            btnSignOut.Visible = false;
            btnAddBook.Visible = false;
        }
        else
        {
            btnSignIn.Visible = false;
            btnSignUp.Visible = false;
            if (Session["UserType"].Equals("Admin"))
            {
                btnAddBook.Visible = true;
            }
            else
            {
                btnAddBook.Visible = false;
            }
        }
    }
    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/UserRegistration.aspx");
    }

    protected void btnCart_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/ShoppingCartPage.aspx");  
    }

    protected void btnAddBook_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/BookRegistration.aspx");
    }
}
