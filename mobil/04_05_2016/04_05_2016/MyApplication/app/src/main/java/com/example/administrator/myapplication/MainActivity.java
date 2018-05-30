package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;


public class MainActivity extends Activity
{
    ListView lstSehirler;
    ArrayList<String> Sehirler;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        Sehirler = new ArrayList<String>();
        Sehirler.add("İstanbul");
        Sehirler.add("Ankara");
        Sehirler.add("Malatya");
        Sehirler.add("Bingöl");
        Sehirler.add("Bayburt");
        Sehirler.add("İzmir");
        Sehirler.add("Muğla");
        Sehirler.add("Kars");

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        lstSehirler = (ListView)findViewById(R.id.listView1);

        ArrayAdapter<String> adapter = new ArrayAdapter<String>(MainActivity.this,
                                                                R.layout.my_listview_item,
                                                                R.id.txtSehir,
                                                                Sehirler);
        lstSehirler.setAdapter(adapter);

        lstSehirler.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                TextView txtSehir = (TextView) view.findViewById(R.id.txtSehir);
                Toast.makeText(MainActivity.this,
                               "Şehir : " + txtSehir.getText(),
                               Toast.LENGTH_SHORT).show();
            }
        });

    }

}
