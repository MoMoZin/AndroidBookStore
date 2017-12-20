using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

    [OperationContract]
    [WebGet(UriTemplate = "/GetBook/{isbn}", ResponseFormat = WebMessageFormat.Json)]
    WCFBook GetBook(string isbn);

    [OperationContract]
    [WebGet(UriTemplate = "/Book", ResponseFormat = WebMessageFormat.Json)]
    string[] ListBook();

    // TODO: Add your service operations here
}
[DataContract]
public class WCFBook
{
    int bookId;
    string title;
    string isbn;
    string author;
    int stock;
    decimal price;
    string category;

    public static WCFBook Make(int bookId, string title, string isbn, string author, int stock, decimal price, string category)
    {
        WCFBook b = new WCFBook();
        b.bookId = bookId;
        b.title = title;
        b.isbn = isbn;
        b.author = author;
        b.stock = stock;
        b.price = price;
        b.category = category;
        return b;
    }

    [DataMember]
    public int BookId
    {
        get { return bookId; }
        set { bookId = value; }
    }

    [DataMember]
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    [DataMember]
    public string Isbn
    {
        get { return isbn; }
        set { isbn = value; }
    }

    [DataMember]
    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    [DataMember]
    public int Stock
    {
        get { return stock; }
        set { stock = value; }
    }

    [DataMember]
    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }


    [DataMember]
    public string Category
    {
        get { return category; }
        set { category = value; }
    }
}

