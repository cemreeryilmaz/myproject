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
public class KullaniciAdapter extends ArrayAdapter {

    Context context;
    int resourceId;
    ArrayList<Kullanici> kullanicilar;

    public KullaniciAdapter(Context context, int resource, ArrayList objects) {
        super(context, resource, objects);
        this.context=context;
        this.resourceId=resource;
        this.kullanicilar = objects;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        LayoutInflater inflater = (LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        View kisi_layout = inflater.inflate(resourceId,parent,false);

        TextView txtAd = (TextView)kisi_layout.findViewById(R.id.txtkullaniciadi);
        TextView txtSifre = (TextView)kisi_layout.findViewById(R.id.txtsifre);

        Kullanici kullanici = kullanicilar.get(position);
        txtAd.setText(txtAd.getText());
        txtSifre.setText(txtSifre.getText());

        return kisi_layout;
    }
}
