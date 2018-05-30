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
 * Created by cemreeryilmaz on 19.05.2016.
 */
public class Kisi_Adapter extends ArrayAdapter<Kisi> {

    Context context;
    int resourseID;
    ArrayList<Kisi> Kisiler;

    public Kisi_Adapter(Context context, int resource, ArrayList<Kisi> objects)
    {
        super(context, resource, objects);
        this.context=context;
        this.resourseID=resource;
        this.Kisiler=objects;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        LayoutInflater inflater = (LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        View kisi_layout = inflater.inflate(resourseID,parent,false);

        TextView txtAd = (TextView)kisi_layout.findViewById(R.id.txtAd);
        TextView txtSoyad = (TextView)kisi_layout.findViewById(R.id.txtSoyad);

        Kisi kisi = Kisiler.get(position);
        txtAd.setText(kisi.getAd());
        txtSoyad.setText(kisi.getSoyad());

        return kisi_layout;
    }
}
