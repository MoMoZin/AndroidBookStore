package com.bookstore.team5.bookstore;

import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.EditText;
import android.widget.ImageView;

import java.util.List;

public class DetailsActivity extends AppCompatActivity {

    final static int []view = {R.id.editText1, R.id.editText2, R.id.editText3, R.id.editText4,R.id.editText5,R.id.editText6,R.id.editText7};
    final static String []key = {"BookID", "Title", "CategoryID", "ISBN","Author","Stock","Price"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_details);
        String item = getIntent().getExtras().getString("ISBN");
/*        new AsyncTask<String, Void, List<Book>>() {
            @Override
            protected List<Book> doInBackground(String...params) {
                return Book.jread(params[0],true);
            }
            @Override
            protected void onPostExecute(List<Book> result) {

                for (int i=0; i<view.length; i++) {
                    EditText t = (EditText) findViewById(view[i]);
                    t.setText(result.get(0).get(key[i]));
                }
                //ImageView image = (ImageView) findViewById(R.id.imageView);
                //image.setImageBitmap(Book.getPhoto(result.getIsbn()));
            }
        }.execute(item);*/
    }
}
