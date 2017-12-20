using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SearchCategoryResult : System.Web.UI.Page
{
    BusinessLogic bl;
    BookBusinesslogic bookBusinessLogic;
    protected void Page_Load(object sender, EventArgs e)
    {
        int key = Convert.ToInt32(Request.QueryString[0].ToString());
        bl = new BusinessLogic();
        bookBusinessLogic = new BookBusinesslogic();
        List<Book> lstBook;
        lstBook = bl.GetBooksByCategoryID(key);
        Category cat = bookBusinessLogic.GetCategory(key);
        Label1.Text = cat.CategoryName;
        try
        {
            if (Session["userType"] == null || Session["userType"].Equals("Customer"))
            {
                bl.imageAssignForCustomer(lstBook, PlaceHolder1);
            }
            else if (Session["userType"].Equals("Admin"))
            {
                bl.imageAssign(lstBook, PlaceHolder1);
            }
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(Page.GetType(),
     "MessageBox",
     "<script language='javascript'>alert('" + ex.Message + "');</script>");
        }
    }
}