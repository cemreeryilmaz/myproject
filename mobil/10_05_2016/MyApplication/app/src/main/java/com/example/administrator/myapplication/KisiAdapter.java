package com.example.administrator.myapplication;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Administrator on 10.05.2016.
 */
public class KisiAdapter extends ArrayAdapter<Kisi>
{
    Context context;
    int LayoutResourseID;
    ArrayList<Kisi> Kisiler;


    public KisiAdapter(Context context, int resource, ArrayList<Kisi> objects)
    {
        super(context, resource, objects);
        this.context = context;
        this.LayoutResourseID = resource;
        this.Kisiler = objects;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent)
    {
        LayoutInflater inflater = (LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        View kisi_layout = inflater.inflate(LayoutResourseID, parent, false);

        TextView txtKisi = (TextView)kisi_layout.findViewById(R.id.txtKisi);

        Kisi kisi = Kisiler.get(position);
        txtKisi.setText(kisi.getAd()+" "+kisi.getSoyad());

        return kisi_layout;
    }
}
