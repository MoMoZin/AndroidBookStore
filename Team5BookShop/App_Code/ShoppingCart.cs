using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShoppingCart
/// </summary>
public class ShoppingCart
{
    List<CartItem> cart;

    public ShoppingCart()
    {
        cart = new List<CartItem>();
    }

    public bool Add(Book book, int quantity)
    {
        if (book.Stock >= quantity)
        {
            CartItem newItem = new CartItem(book, quantity);
            cart.Add(newItem);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Update(int index, int newQuantity)
    {
        if(cart[index].Stock >= newQuantity)
        {
            cart[index].Quantity = newQuantity;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Clear()
    {
        cart.Clear();
    }
    public void Remove(int index)
    {
        if(index >= 0 && index < cart.Count)
        {
            if(cart[index] != null)
            {
                cart.Remove(cart[index]);
            }
        }
    }
    public List<CartItem> Cart
    {
        get
        {
            return cart;
        }
    }

    public decimal TotalPrice()
    {
        decimal totalPrice = 0;
        foreach (CartItem cartItem in cart)
        {
            totalPrice += cartItem.SubTotal;
        }
        return totalPrice;
    }
}