package com.bookstore.team5.bookstore;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.AsyncTask;
import android.os.Parcelable;
import android.util.Log;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.InputStream;
import java.net.URL;
import java.net.URLConnection;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

/**
 * Created by edwon on 20/12/2017.
 */

public class Book extends HashMap<String, String> {

    private static final List<Book> bookList = jread("http://172.17.249.125/BookShopTeam5/Service.svc/Book", true);
    final static String imageUrl="";

    public Book(Integer bookId, String title, String categoryName, String isbn, String author, Integer stock, String price) {
        put("bookId", bookId.toString());
        put("title", title);
        put("categoryName", categoryName);
        put("isbn", isbn);
        put("author", author);
        put("stock", stock.toString());
        put("price", price);
    }

    public static List<Book> getBookList() {
        return bookList;
    }

    public Book(String title, String categoryName, String author) {
        put("title", title);
        put("categoryName", categoryName);
        put("author", author);
    }
    // this is just for testing list display(to be removed)
    public static List<Book> testbook(){
        List<Book> list = new ArrayList<Book>();
        list.add(new Book(1111,"megan and me","fiction","A123456","Mr Awesome",12,"12.40"));
        list.add(new Book(1112,"How I became a magical princess","self-improvement","A123457","Mr Awesome",11,"12.00"));
        list.add(new Book(1113,"megan the explorer","erotica","A123458","Mr Awesome",10,"11.40"));
        return list;
    }


    public static List<Book> jread(String queryUrl, boolean detailsQuery) {
        final List<Book> list = new ArrayList<Book>();
        final boolean queryMode = detailsQuery;

        new AsyncTask<String, Void, JSONArray>(){

            @Override
            protected JSONArray doInBackground(String... url) {
                JSONArray a = JSONParser.getJSONArrayFromUrl(url[0]);
                return a;
            }

            @Override
            protected void onPostExecute(JSONArray a){
                try {
                    for (int i = 0; i < a.length(); i++) {
                        JSONObject b = a.getJSONObject(i);
                        if(queryMode == false) {
                            list.add(new Book(b.getString("Title"), b.getString("Category"), b.getString("Author")));
                        }
                        else{
                            list.add(new Book(b.getInt("BookId"), b.getString("Title"), b.getString("Category"), b.getString("Isbn"), b.getString("Author"), b.getInt("Stock"), b.getString("Price")));
                        }
                    }
                } catch (Exception e) {
                    Log.e("NewsItem", "JSONArray error");
                }
            }
        }.execute(queryUrl);

        return (list);
    }

    public static Bitmap getPhoto(String isbn){
        try {
            URL url=new URL(String.format("%s/%s.jpg",imageUrl,isbn));
            URLConnection connection=url.openConnection();
            InputStream inputStream=connection.getInputStream();
            Bitmap bitmap= BitmapFactory.decodeStream(inputStream);
            inputStream.close();
            return bitmap;
        }
        catch (Exception e){
            Log.e("Book.getPhoto","Bitmap error");
        }
        return null;
    }
}
