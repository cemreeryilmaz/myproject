package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

import java.util.ArrayList;


public class MainActivity extends Activity
{
    Spinner sp1;

    ArrayList<String> Kisiler;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        Kisiler = new ArrayList<String>();
        Kisiler.add("Kemalettin Kamiloğlu");
        Kisiler.add("Muhittin Kamiloğlu");
        Kisiler.add("Nurettin Beyaz");
        Kisiler.add("Hayrettin Hayroğlu");
        Kisiler.add("Safettin Safoğlu");

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ArrayAdapter adapter = new ArrayAdapter(MainActivity.this,
                                                android.R.layout.simple_dropdown_item_1line,
                                                Kisiler);

        sp1 = (Spinner)findViewById(R.id.spinner1);

        sp1.setAdapter(adapter);
    }
}
