package com.bookstore.team5.bookstore;

import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.app.ListFragment;
import android.content.Context;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.app.Fragment;
import android.support.v7.widget.GridLayoutManager;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.SimpleAdapter;

import com.bookstore.team5.bookstore.dummy.DummyContent;
import com.bookstore.team5.bookstore.dummy.DummyContent.DummyItem;

import java.util.ArrayList;
import java.util.List;

public class ListingFragment extends ListFragment {
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View v = inflater.inflate(R.layout.list, container, false);
        new AsyncTask<Void,Void,List<Book>>() {
            @Override
            protected List<Book> doInBackground(Void... voids) {
                return Book.getBookList();
            }

            @Override
            protected void onPostExecute(List<Book> books) {
                SimpleAdapter adapter = new SimpleAdapter(getActivity(), books,
                        R.layout.row,
                        new String[]{"title", "author","categoryName"},
                        new int[]{R.id.text1,R.id.text2,R.id.text3});
                setListAdapter(adapter);
            }
        }.execute();
        return(v);
    }

    @Override
    public void onListItemClick(ListView l, View v, int position, long id) {
        Book b = (Book) getListAdapter().getItem(position);
        String isbn= b.get("isbn");
        Intent intent = new Intent(getActivity(), DetailsActivity.class);
        intent.putExtra("ISBN", isbn);
        startActivity(intent);
    }


}