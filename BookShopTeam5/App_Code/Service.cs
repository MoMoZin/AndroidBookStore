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
    //public string GetData(int value)
    //{
    //	return string.Format("You entered: {0}", value);
    //}

    //public CompositeType GetDataUsingDataContract(CompositeType composite)
    //{
    //	if (composite == null)
    //	{
    //		throw new ArgumentNullException("composite");
    //	}
    //	if (composite.BoolValue)
    //	{
    //		composite.StringValue += "Suffix";
    //	}
    //	return composite;
    //}
    public string[] ListBook()
    {
        return Data.ListBook().ToArray<string>();
    }

    public WCFBook GetBook(string isbn)
    {
        Book b = Data.GetBookDetails(isbn);

        String categoryName = Data.GetCategory(b.CategoryID).CategoryName;

        return WCFBook.Make(b.BookID, b.Title, b.ISBN, b.Author, b.Stock, b.Price, categoryName);
    }

}
