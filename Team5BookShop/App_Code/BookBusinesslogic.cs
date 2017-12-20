using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for BookBusinesslogic
/// </summary>
public class BookBusinesslogic
{
    Book book;
    int catId;
    BookshopEntities be;
    Category category;

    public BookBusinesslogic()
    {

    }

    public Book GetBookDetails(string id)
    {
        using (BookshopEntities bookEntity = new BookshopEntities())
        {
            book = (from bk in bookEntity.Books
                    where bk.ISBN == id
                    select bk).First();
            catId = book.CategoryID;
            return book;
        }

    }
    public Category GetCategory(int catId)
    {
        using (BookshopEntities category = new BookshopEntities())
        {
            Category catgry = (from ct in category.Categories
                               where ct.CategoryID == catId
                               select ct).First();
            return catgry;
        }
    }

    public bool AddBook(string title, string cat, string isbn, string author, int stock, decimal price)
    {
        be = new BookshopEntities();
        book = new Book();
        category = new Category();

        try
        {
            book.Title = title;
            book.ISBN = isbn;
            book.Author = author;
            book.Stock = stock;
            book.Price = price;

            var c = be.Categories.Where(x => x.CategoryName == cat).Select(x => x.CategoryID).First();
            book.CategoryID = c;

            be.Books.Add(book);

            be.SaveChanges();


            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public bool DeleteBook(string isbn)
    {
        try
        {
            be = new BookshopEntities();
            Book b = be.Books.Where(x => x.ISBN == isbn).First();
            be.Books.Remove(b);
            be.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public void UpdateBook(string isbn, string bookCategory, string title, string author, string price, string stock)
    {
        using (BookshopEntities context = new BookshopEntities())
        {
            Book b = context.Books.Where(x => x.ISBN == isbn).First();
            b.CategoryID = context.Categories.Where(x => x.CategoryName == bookCategory).Select(y => y.CategoryID).First();
            b.Title = title;
            b.Author = author;
            decimal newPrice;
            bool validPrice = Decimal.TryParse(price, out newPrice);
            int newStock;
            bool validStock = Int32.TryParse(stock, out newStock);
            
            if (validPrice && validStock)
            {
                b.Price = newPrice;
                b.Stock = newStock;
                
                context.SaveChanges();
            }
        }
    }
}
