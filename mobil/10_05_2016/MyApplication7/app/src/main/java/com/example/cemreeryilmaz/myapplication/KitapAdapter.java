package com.example.cemreeryilmaz.myapplication;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by cemreeryilmaz on 24.05.2016.
 */
public class KitapAdapter extends ArrayAdapter {

    Context context;
    int resourceId;
    ArrayList<Kitap> kitaplar;

    public KitapAdapter(Context context, int resource, ArrayList objects) {
        super(context, resource, objects);
        this.context=context;
        this.resourceId=resource;
        this.kitaplar=objects;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        LayoutInflater inflater = (LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        View kitap_layout = inflater.inflate(resourceId,parent,false);

        TextView txtyazarAd = (TextView)kitap_layout.findViewById(R.id.txtyazarAd);
        TextView txtkitapAd = (TextView)kitap_layout.findViewById(R.id.txtkitapAd);

        Kitap kitap = kitaplar.get(position);
        txtyazarAd.setText(txtyazarAd.getText());
        txtkitapAd.setText(txtkitapAd.getText());

        return kitap_layout;
    }
}
