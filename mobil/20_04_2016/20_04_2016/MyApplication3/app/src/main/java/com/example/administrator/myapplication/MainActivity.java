package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.widget.CompoundButton;
import android.widget.Switch;


public class MainActivity extends Activity implements CompoundButton.OnCheckedChangeListener
{
    Switch sw1;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        sw1 = (Switch)findViewById(R.id.switch1);
        sw1.setOnCheckedChangeListener(this);
    }

    @Override
    public void onCheckedChanged(CompoundButton buttonView, boolean isChecked)
    {
        if(isChecked)
            sw1.setText("Switch AÇIK");
        else
            sw1.setText("Switch KAPALI");
    }
}
