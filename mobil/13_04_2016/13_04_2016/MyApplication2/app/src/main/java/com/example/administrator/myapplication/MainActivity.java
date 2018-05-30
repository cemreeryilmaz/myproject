package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;


public class MainActivity extends Activity implements View.OnClickListener{

    Button btnArtır, btnAzalt, btnSıfırla;
    TextView txtSayac;

    int sayac = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        txtSayac = (TextView)findViewById(R.id.txtSayac);
        btnArtır = (Button)findViewById(R.id.btnArtır);
        btnAzalt = (Button)findViewById(R.id.btnAzalt);
        btnSıfırla = (Button)findViewById(R.id.btnSıfırla);

        btnArtır.setOnClickListener(this);
        btnAzalt.setOnClickListener(this);
        btnSıfırla.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        if(v.getId() == R.id.btnArtır)
            sayac++;
        else if(v.getId() == R.id.btnAzalt)
            sayac--;
        else if(v.getId() == R.id.btnSıfırla)
            sayac = 0;

        txtSayac.setText(String.valueOf(sayac));
    }
}
