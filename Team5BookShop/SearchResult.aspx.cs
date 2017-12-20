using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;

public partial class SearchResult : System.Web.UI.Page
{
    BusinessLogic bl;
    protected void Page_Load(object sender, EventArgs e)
    {        
        bl = new BusinessLogic();
        string search;
        search = (string)(Session["SearchItem"]);
        List<Book> lstBook;
        lstBook = bl.GetBooksByTitle(search);

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