using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookUpdate : System.Web.UI.Page
{
    BookBusinesslogic bbl;
    BusinessLogic bl;
    Book bookItem;


    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            string val = Request.QueryString["ISBN"];
            if (val != null)
            {

                bookItem = new Book();
                bbl = new BookBusinesslogic();
                bl = new BusinessLogic();

                bookItem = bbl.GetBookDetails(val);

                txtISBN.Text = val;

                Image2.Width = 150;
                Image2.Height = 150;
                Image2.ImageUrl = "images/" + val + ".jpg";

                List<string> cat = bl.GetCategoryList();
                for (int i = 0; i < cat.Count; i++)
                {
                    ddlistCat.Items.Add(cat[i]);
                }
                string catName = bbl.GetCategory(bookItem.CategoryID).CategoryName.ToString();
                ddlistCat.ClearSelection();
                ddlistCat.SelectedValue = catName;

                txtTitle.Text = bookItem.Title;
                txtAuthor.Text = bookItem.Author;
                txtPrice.Text = bookItem.Price.ToString();
                bookStock.Value = bookItem.Stock.ToString();
            }
        }        
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (bookStock.Value == "")
        {
            lblStock.Text = "Value cannot be empty";
        }
        else
        {
            try
            {
                string title = this.txtTitle.Text;
                string cat = this.ddlistCat.SelectedValue.ToString();
                string isbn = this.txtISBN.Text;
                string author = this.txtAuthor.Text;
                string stock = this.bookStock.Value;
                string price = this.txtPrice.Text;

                bbl = new BookBusinesslogic();

                bbl.UpdateBook(isbn, cat, title, author, price, stock);                

                Response.Redirect("Main.aspx");
            }
            catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(Page.GetType(),
       "MessageBox",
       "<script language='javascript'>alert('" + ex.Message + "');</script>");
            }
        }

        }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            bbl.DeleteBook(txtISBN.Text);
            Response.Redirect("Main.aspx");
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(Page.GetType(),
       "MessageBox",
       "<script language='javascript'>alert('" + ex.Message + "');</script>");
        }
    }
}