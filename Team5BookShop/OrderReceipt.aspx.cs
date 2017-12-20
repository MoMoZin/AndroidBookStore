using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderReceipt : System.Web.UI.Page
{
    ShoppingCart userCart;
    string mailingAddress;
    protected void Page_Load(object sender, EventArgs e)
    {
        userCart = (ShoppingCart)Session["ShoppingCartObj"];
        GridView1.DataSource = userCart.Cart;
        GridView1.DataBind();
        failurelb.Visible = false;
    }

    protected void PurchaseBtn_Click(object sender, EventArgs e)
    {
        string userID = Session["UserID"].ToString();
        mailingAddress= Addresstb.Text+","+StateCitytb.Text+","+Countrytb.Text+","+ZipCodetb.Text;
        BusinessLogic buzy = new BusinessLogic();
        if (buzy.Checkout(userID, mailingAddress, DateTime.Now.Date, userCart.TotalPrice(), userCart))
        {
            Response.Redirect("~/CheckOutSuccess.aspx");
        }
        else
        {
            failurelb.Visible = true;
            failurelb.Text = "Failed to log purchase. Please try again later";
        }
    }
}