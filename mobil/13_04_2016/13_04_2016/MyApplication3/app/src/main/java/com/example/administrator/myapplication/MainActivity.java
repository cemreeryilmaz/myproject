package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.TextView;


public class MainActivity extends Activity {

    TextView txtSayac;
    int sayac = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        txtSayac = (TextView)findViewById(R.id.txtSayac);
    }

    public void btnArtır_OnClick(View v)
    {
        sayac++;
        txtSayac.setText(String.valueOf(sayac));
    }

    public void btnAzalt_OnClick(View v)
    {
        sayac--;
        txtSayac.setText(String.valueOf(sayac));
    }

    public void btnSıfırla_OnClick(View v)
    {
        sayac = 0;
        txtSayac.setText(String.valueOf(sayac));
    }
}
