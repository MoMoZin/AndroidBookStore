package com.bookstore.team5.bookstore;

import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.app.ListFragment;
import android.content.Context;
import android.content.Intent;
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
        SimpleAdapter adapter = new SimpleAdapter(getActivity(),Book.testbook(),
                android.R.layout.simple_list_item_2,
                new String[]{"title","author"},
                new int[]{android.R.id.text1, android.R.id.text2});
/*        SimpleAdapter adapter = new SimpleAdapter(getActivity(),Book.jread("",false),
                android.R.layout.simple_list_item_2,
                new String[]{"title","author"},
                new int[]{android.R.id.text1, android.R.id.text2});*/
        setListAdapter(adapter);
        return(v);
    }

    @Override
    public void onListItemClick(ListView l, View v, int position, long id) {
        Book b = (Book) getListAdapter().getItem(position);
        Intent intent = new Intent(getActivity(), DetailsActivity.class);
        intent.putExtra("book", b);
        startActivity(intent);
    }


}