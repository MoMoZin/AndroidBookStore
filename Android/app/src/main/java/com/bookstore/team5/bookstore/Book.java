package com.bookstore.team5.bookstore;

import android.os.Parcelable;
import android.util.Log;

import org.json.JSONArray;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

/**
 * Created by edwon on 20/12/2017.
 */

public class Book extends HashMap<String, String> {

    public Book(Integer bookId, String title, String categoryName, String isbn, String author, Integer stock, String price, Integer discountCode) {
        put("bookId", bookId.toString());
        put("title", title);
        put("categoryName", categoryName);
        put("isbn", isbn);
        put("author", author);
        put("stock", stock.toString());
        put("price", price);
        put("discountCode", discountCode.toString());
    }

    public Book(String title, String categoryName, String author) {
        put("title", title);
        put("categoryName", categoryName);
        put("author", author);
    }
    // this is just for testing list display(to be removed)
    public static List<Book> testbook(){
        List<Book> list = new ArrayList<Book>();
        list.add(new Book(1111,"megan and me","fiction","A123456","Mr Awesome",12,"12.40",124));
        list.add(new Book(1112,"megan and you","fiction","A123457","Mr Awesome",11,"12.00",124));
        list.add(new Book(1113,"megan the explorer","erotica","A123458","Mr Awesome",10,"11.40",124));
        return list;
    }


    public static List<Book> jread(String queryUrl, boolean detailsQuery) {
        List<Book> list = new ArrayList<Book>();
        JSONArray a = JSONParser.getJSONArrayFromUrl(queryUrl);
        try {
            for (int i = 0; i < a.length(); i++) {
                JSONObject b = a.getJSONObject(i);
                if(detailsQuery == false) {
                    list.add(new Book(b.getString("title"), b.getString("categoryName"), b.getString("author")));
                }
                else{
                    list.add(new Book(b.getInt("bookId"), b.getString("title"), b.getString("categoryName"), b.getString("isbn"), b.getString("author"), b.getInt("stock"), b.getString("price"), b.getInt("discountCode")));
                }
            }
        } catch (Exception e) {
            Log.e("NewsItem", "JSONArray error");
        }
        return (list);
    }
}
