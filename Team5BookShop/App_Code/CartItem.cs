using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartItem
/// </summary>
public class CartItem
{

    string title;
    int quantity;
    decimal unitPrice;
    int bookID;
    int stock;

    public CartItem(Book book, int quantity)
    {
        this.title = book.Title;
        this.quantity = quantity;
        this.unitPrice = book.Price;
        this.bookID = book.BookID;
        this.stock = book.Stock;
    }

    public string Title
    {
        get
        {
            return title;
        }
    }

    public int Stock
    {
        get
        {
            return stock;
        }
    }

    public int Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
            quantity = value;
        }
    }

    public decimal UnitPrice
    {
        get
        {
            return unitPrice;
        }
    }

    public int BookID
    {
        get
        {
            return bookID;
        }
    }

    public decimal SubTotal
    {
        get
        {
            return unitPrice * quantity;
        }
    }
}