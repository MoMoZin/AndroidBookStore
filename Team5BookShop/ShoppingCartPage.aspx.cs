using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShoppingCartPage : System.Web.UI.Page
{
    ShoppingCart userCart;
    BookshopEntities bk = new BookshopEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        userCart = (ShoppingCart)Session["ShoppingCartObj"];
        if (userCart.Cart.Count == 0)
        {
            ShoppingLb.Text = "Your Shopping Cart is Empty";
            GridView1.Visible = false;
            CheckoutBtn.Visible = false;
            UpdateBtn.Visible = false;
        }
        else
        {
            ShoppingLb.Text = "Shopping Cart";
            GridView1.DataSource = userCart.Cart;
            if (!IsPostBack)
            {
                GridView1.DataBind();
            }
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteCartItem")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            userCart.Remove(index);
            GridView1.DataBind();
            Session["ShoppingCartObj"] = userCart;
            Response.Redirect("~/ShoppingCartPage.aspx");
        }
    }

    protected void CheckoutBtn_Click(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Session["Url"] = HttpContext.Current.Request.Url.AbsoluteUri;
            Response.Redirect("~/LogIn.aspx");
        }
        else
        {
            Session["Url"] = HttpContext.Current.Request.Url.AbsoluteUri;
            Response.Redirect("~/OrderReceipt.aspx");
        }
    }

    protected void UpdateBtn_Click(object sender, EventArgs e)
    {
        int j = 0;
        for (int i = 0; i < GridView1.Rows.Count && i < userCart.Cart.Count; i++)
        {
            int input = Convert.ToInt32(((TextBox)GridView1.Rows[i].FindControl("Quantitytb")).Text);
            if (userCart.Cart[i].Quantity != input)
            {
                userCart.Update(i, input);
            }
        }
        while (j < userCart.Cart.Count)
        {
            if (userCart.Cart[j].Quantity <= 0)
            {
                userCart.Remove(j);
            }
            else
            {
                j++;
            }
        }
        GridView1.DataBind();
        Session["ShoppingCartObj"] = userCart;
        Response.Redirect("~/ShoppingCartPage.aspx");
    }
}

