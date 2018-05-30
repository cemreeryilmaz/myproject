package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.TextView;


public class MainActivity extends Activity implements CompoundButton.OnCheckedChangeListener
{
    TextView txtMalzemeler;
    CheckBox chkMarul, chkSalatalık, chkMaydanoz, chkRoka;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        txtMalzemeler = (TextView)findViewById(R.id.txtMalzemeler);
        chkMarul = (CheckBox)findViewById(R.id.chkMarul);
        chkMaydanoz = (CheckBox)findViewById(R.id.chkMaydanoz);
        chkRoka = (CheckBox)findViewById(R.id.chkRoka);
        chkSalatalık = (CheckBox)findViewById(R.id.chkSalatalık);

        chkMarul.setOnCheckedChangeListener(this);
        chkMaydanoz.setOnCheckedChangeListener(this);
        chkSalatalık.setOnCheckedChangeListener(this);
        chkRoka.setOnCheckedChangeListener(this);
    }

    @Override
    public void onCheckedChanged(CompoundButton buttonView, boolean isChecked)
    {
        String strMalzemeler = "";

        if(chkMarul.isChecked())
            strMalzemeler = "Marul";
        if(chkRoka.isChecked())
            strMalzemeler =(strMalzemeler.isEmpty())? "Roka" : strMalzemeler + " + Roka";
        if(chkSalatalık.isChecked())
            strMalzemeler =(strMalzemeler.isEmpty())? "Salatalık" : strMalzemeler + " + Salatalık";
        if(chkMaydanoz.isChecked())
            strMalzemeler =(strMalzemeler.isEmpty())? "Maydanoz" : strMalzemeler + " + Maydanoz";

        txtMalzemeler.setText(strMalzemeler);
    }
}
