using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public WCFBook[] ListBook()
    {
        
        List<Book> bookList = Data.ListBook();
        WCFBook[] wcfBookList = new WCFBook[bookList.Count];
        for (int i= 0; i< bookList.Count; i++)
        {
            Book b = bookList[i];
            String categoryName = Data.GetCategory(b.CategoryID).CategoryName;
            wcfBookList[i] = WCFBook.Make(b.BookID, b.Title, b.ISBN, b.Author, b.Stock, b.Price, categoryName);
        }
        return wcfBookList;
    }

    public WCFBook GetBook(string isbn)
    {
        Book b = Data.GetBookDetails(isbn);

        String categoryName = Data.GetCategory(b.CategoryID).CategoryName;

        return WCFBook.Make(b.BookID, b.Title, b.ISBN, b.Author, b.Stock, b.Price, categoryName);
    }

}
