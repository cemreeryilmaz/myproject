package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.widget.CompoundButton;
import android.widget.Toast;
import android.widget.ToggleButton;


public class MainActivity extends Activity implements CompoundButton.OnCheckedChangeListener
{
    ToggleButton tgButton1;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        tgButton1 = (ToggleButton)findViewById(R.id.toggleButton1);
        tgButton1.setOnCheckedChangeListener(this);
    }

    @Override
    public void onCheckedChanged(CompoundButton buttonView, boolean isChecked)
    {
           if(isChecked)
               Toast.makeText(MainActivity.this,
                              "Toggle Button Açık",
                              Toast.LENGTH_SHORT).show();
        else
               Toast.makeText(MainActivity.this,
                       "Toggle Button Kapalı",
                       Toast.LENGTH_SHORT).show();
    }
}
