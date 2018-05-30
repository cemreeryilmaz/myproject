package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

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
        Kisiler.add("Safettin Safoğlu");
        Kisiler.add("Cemalettin Morcivert");
        Kisiler.add("Nükrettin Lacivert");
        Kisiler.add("Nurettin Beyaz");

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ArrayAdapter adapter = new ArrayAdapter(MainActivity.this,R.layout.my_spinner_item,R.id.txtAdSoyad, Kisiler);

        sp1 = (Spinner)findViewById(R.id.spinner1);
        sp1.setAdapter(adapter);

        sp1.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {

                TextView txtadsoyad = (TextView) view.findViewById(R.id.txtAdSoyad);
                Toast.makeText(MainActivity.this, txtadsoyad.getText(), Toast.LENGTH_SHORT).show();

            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {

            }
        });
    }
}
