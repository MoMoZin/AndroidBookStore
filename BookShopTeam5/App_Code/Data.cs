using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Data
/// </summary>
public class Data
{
    public Data()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static List<Book> ListBook()
    {
        using (BookshopEntities b = new BookshopEntities())
        {
            Console.Write(b.Books.Select<Book, string>(isbn => isbn.ISBN).ToList<string>()[0]);
            return b.Books.ToList<Book>();
        }
    }
    public static Book GetBookDetails(string id)
    {
        using (BookshopEntities bookEntity = new BookshopEntities())
        {
            Book book = (from bk in bookEntity.Books
                    where bk.ISBN == id
                    select bk).First();
            return book;
        }

    }

    public static Category GetCategory(int catId)
    {
        using (BookshopEntities category = new BookshopEntities())
        {
            Category catgry = (from ct in category.Categories
                               where ct.CategoryID == catId
                               select ct).First();
            return catgry;
        }
    }
}