using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    BusinessLogic bl;

    protected void Page_Load(object sender, EventArgs e)
    {
        bl = new BusinessLogic();
        List<Book> lstBook;
        lstBook = bl.GetAllBooks();
        try
        {
            if(Session["userType"] == null || Session["userType"].Equals("Customer"))
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

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Session["SearchItem"] = Master.FindControl("txtSearch").ToString();
        Response.Redirect("SearchResult.aspx");
    }
}