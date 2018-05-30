package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.widget.ListView;
import android.widget.Spinner;

import java.util.ArrayList;


public class MainActivity extends Activity
{
    ListView lstKisiler;
    ArrayList<Kisi> Kisiler;
    Spinner spKisiler;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        Kisiler = new ArrayList<Kisi>();
        Kisiler.add(new Kisi(Kisi.CINSIYET_ERKEK, "Kemalettin", "Kamiloğlu"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_ERKEK, "Cemalettin", "Yeşil"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_KADIN, "Safiye", "Lacivert"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_KADIN, "Necmiye", "Morcivert"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_ERKEK, "Muhittin", "Mahmutoğlu"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_ERKEK, "Fıdıl", "Fındık"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_KADIN, "Şukufe", "Sarı"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_ERKEK, "Necmettin", "Kırmızı"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_ERKEK, "Safettin", "Beyaz"));


        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        myKisiAdapter adapter = new myKisiAdapter(MainActivity.this, R.layout.my_listview_item, Kisiler);

        lstKisiler = (ListView)findViewById(R.id.lstKisiler);
        lstKisiler.setAdapter(adapter);

        spKisiler = (Spinner)findViewById(R.id.spKisiler);
        spKisiler.setAdapter(adapter);
    }
}
