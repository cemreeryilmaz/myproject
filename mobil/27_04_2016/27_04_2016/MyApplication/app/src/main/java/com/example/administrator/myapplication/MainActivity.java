package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.ProgressBar;
import android.widget.TextView;


public class MainActivity extends Activity
{
    TextView txtDeger;
    ProgressBar prgBar;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        txtDeger = (TextView)findViewById(R.id.txtDeger);
        prgBar = (ProgressBar)findViewById(R.id.progressBar1);
    }

    public void btnAzalt_Click(View v)
    {
        if(prgBar.getProgress() > 0)
            prgBar.setProgress(prgBar.getProgress() - 1);
        else
            prgBar.setProgress(prgBar.getMax());

        txtDeger.setText(String.valueOf(prgBar.getProgress()));
    }

    public void btnArtır_Click(View v)
    {
        if(prgBar.getProgress() < prgBar.getMax())
            prgBar.setProgress(prgBar.getProgress() + 1);
        else
            prgBar.setProgress(0);

        txtDeger.setText(String.valueOf(prgBar.getProgress()));
    }
}
