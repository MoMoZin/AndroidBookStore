package com.bookstore.team5.bookstore;

import android.graphics.Bitmap;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.EditText;
import android.widget.ImageView;

import java.util.ArrayList;
import java.util.List;

public class DetailsActivity extends AppCompatActivity {

    final static int[] view = {R.id.editText1, R.id.editText2, R.id.editText3, R.id.editText4, R.id.editText5, R.id.editText6, R.id.editText7};
    final static String[] key = {"bookId", "title", "categoryName", "isbn", "author", "stock", "price"};
    String item;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_details);
        item = getIntent().getStringExtra("ISBN");

        new AsyncTask<Void,Void,List<Book>>(){
            @Override
            protected List<Book> doInBackground(Void... voids) {
                return Book.getBookList();
            }

            @Override
            protected void onPostExecute(List<Book> books) {

                List<Book> bookhold =new ArrayList<Book>();
                for(Book book:books){
                    if(book.get("isbn").equals(item)){
                        bookhold.add(book);
                    }
                }

                for (int i = 0; i < view.length; i++) {
                    EditText t = (EditText) findViewById(view[i]);
                    t.setText(bookhold.get(0).get(key[i]));
                }
            }
        }.execute();

        final ImageView image = (ImageView) findViewById(R.id.imageView);
        new AsyncTask<String, Void, Bitmap>() {
           @Override
           protected Bitmap doInBackground(String... params) {
                return Book.getPhoto(params[0]);
            }

            @Override
            protected void onPostExecute(Bitmap result) {
                image.setImageBitmap(result);
            }
        }.execute(item);

    }
}