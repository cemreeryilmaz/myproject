package com.example.administrator.myapplication;

import android.content.Context;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Administrator on 04.05.2016.
 */
public class myKisiAdapter extends ArrayAdapter<Kisi> {

    Context context;
    int LayoutResouceID;
    ArrayList<Kisi> Kisiler;

    public myKisiAdapter(Context context, int resource, ArrayList<Kisi> objects)
    {
        super(context, resource, objects);
        this.context = context;
        this.LayoutResouceID = resource;
        Kisiler = objects;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent)
    {

        LayoutInflater inflater = (LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);

        View view_kisi = inflater.inflate(LayoutResouceID, parent, false);

        ImageView imgUserIco = (ImageView)view_kisi.findViewById(R.id.imgUserIco);
        TextView txtAd = (TextView)view_kisi.findViewById(R.id.txtAd);
        TextView txtSoyad = (TextView)view_kisi.findViewById(R.id.txtSoyad);

        Kisi kisi = Kisiler.get(position);


        txtAd.setText(kisi.getAd());
        txtSoyad.setText(kisi.getSoyad());

        if(kisi.getCinsiyet() == Kisi.CINSIYET_ERKEK)
            imgUserIco.setImageDrawable(context.getResources().getDrawable(R.drawable.man_ico));
        else
            imgUserIco.setImageDrawable(context.getResources().getDrawable(R.drawable.woman_ico));

        return view_kisi;
    }
}
