using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    BookshopEntities bk = new BookshopEntities();
    string isbn;
    Book bookItem;

    protected void Page_Load(object sender, EventArgs e)
    {
        string val = Request.QueryString["BookID"];
        if (val != null)
        {
            isbn = val;
            bookItem = new BookBusinesslogic().GetBookDetails(isbn);
            Category cat = new BookBusinesslogic().GetCategory(bookItem.CategoryID);
            Image2.Width = 280;
            Image2.Height = 280;
            Image2.ImageUrl = "images/" + bookItem.ISBN + ".jpg";
            lblTitle.Text = bookItem.Title;
            lblCat.Text = Convert.ToString(cat.CategoryName);
            lblISBN.Text = bookItem.ISBN;
            lblAuthor.Text = bookItem.Author;
            lblPrice.Text = Convert.ToString(bookItem.Price);
        }
    }
            
    protected void BtnAddToCart_Click1(object sender, EventArgs e)
    {
        int quantity = Convert.ToInt32(qty.Value);
        ShoppingCart sc = (ShoppingCart)Session["ShoppingCartObj"];

        if (sc.Add(bookItem, quantity))
        {
            Session["ShoppingCartObj"] = sc;
            Response.Redirect("~/Main.aspx");
        }
        else
        {
            Label1.Text = "Invalid Quantity";
        }
    }
}

 