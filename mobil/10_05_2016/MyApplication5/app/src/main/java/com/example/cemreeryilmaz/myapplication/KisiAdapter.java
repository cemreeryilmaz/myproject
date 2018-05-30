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
public class KisiAdapter extends ArrayAdapter {

    Context context;
    int resourceId;
    ArrayList<Kisi> kisiler;

    public KisiAdapter(Context context, int resource, ArrayList objects) {
        super(context, resource, objects);
        this.context=context;
        this.resourceId=resource;
        this.kisiler=objects;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        LayoutInflater inflater = (LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        View kisi_layout = inflater.inflate(resourceId,parent,false);

        TextView txtAd = (TextView)kisi_layout.findViewById(R.id.txtAd);
        TextView txtSoyad = (TextView)kisi_layout.findViewById(R.id.txtSoyad);

        Kisi kisi = kisiler.get(position);
        txtAd.setText(txtAd.getText());
        txtSoyad.setText(txtSoyad.getText());

        return kisi_layout;
    }
}
