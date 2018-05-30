package com.example.administrator.myapplication;


import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Administrator on 10.05.2016.
 */
public class KisiAdapter extends ArrayAdapter<Kisi>
{
    Context context;
    int resourceID;
    ArrayList<Kisi> Kisiler;

    public KisiAdapter(Context context, int resource, ArrayList<Kisi> objects)
    {
        super(context, resource, objects);
        this.context = context;
        this.resourceID = resource;
        this.Kisiler = objects;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent)
    {
        LayoutInflater inflater = (LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        View kisiView = inflater.inflate(resourceID, parent, false);

        TextView txtAdSoyad = (TextView)kisiView.findViewById(R.id.txtAdSoyad);
        TextView txtTelno = (TextView)kisiView.findViewById(R.id.txtTelNo);
        ImageView imgUserIco = (ImageView)kisiView.findViewById(R.id.imgUserIco);

        Kisi kisi = Kisiler.get(position);
        txtAdSoyad.setText(kisi.getAd()+" "+kisi.getSoyad());
        txtTelno.setText(kisi.getTelNo());

        if(kisi.getCinsiyet() == Kisi.CINSIYET_ERKEK)
        {
            imgUserIco.setImageDrawable(context.getResources().getDrawable(R.drawable.man_ico));
        }
        else if(kisi.getCinsiyet() == Kisi.CINSIYET_KADIN)
        {
            imgUserIco.setImageDrawable(context.getResources().getDrawable(R.drawable.woman_ico));
        }
        return kisiView;
    }
}
