using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class BookRegistration : System.Web.UI.Page
{
    BusinessLogic bl;
    BookBusinesslogic bbl;
    protected void Page_Load(object sender, EventArgs e)
    {
        bl = new BusinessLogic();
        List<string> cat = bl.GetCategoryList();
        for(int i=0; i<cat.Count; i++)
        {
            ddlistCat.Items.Add(cat[i]);
        }

       
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {        
        if(bookStock.Value == "")
        {
            lblStock.Text = "Value cannot be empty";
        }
        else
        {
            if (FileUpload1.HasFile)
            {
                bbl = new BookBusinesslogic();

                string title = txtTitle.Text;
                string cat = ddlistCat.SelectedValue.ToString();
                string isbn = txtISBN.Text;
                string author = txtAuthor.Text;
                int stock = Convert.ToInt32(bookStock.Value);
                decimal price = Convert.ToDecimal(txtPrice.Text);

                try
                {
                    FileUpload1.SaveAs(Server.MapPath("~/images/") + isbn + ".jpg");
                }
                catch(Exception ex)
                {
                    ClientScript.RegisterStartupScript(Page.GetType(),
       "MessageBox",
       "<script language='javascript'>alert('"+ex.Message+"');</script>");

                }               

                if (bbl.AddBook(title, cat, isbn, author, stock, price))
                {
                    ClientScript.RegisterStartupScript(Page.GetType(),
       "MessageBox",
       "<script language='javascript'>alert('Adding Book Successful!');</script>");
                    Response.Redirect("Main.aspx");
                } 
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(),
       "MessageBox",
       "<script language='javascript'>alert('Error!');</script>");
                }   
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(),
    "MessageBox",
    "<script language='javascript'>alert('Please upload Image!');</script>");
            }            
        }       
    }
}