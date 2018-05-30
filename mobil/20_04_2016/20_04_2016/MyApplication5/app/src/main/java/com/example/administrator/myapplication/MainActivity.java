package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.Toast;


public class MainActivity extends Activity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void imageButton_Click(View v)
    {
        Toast.makeText(MainActivity.this,
                       "Tıklandı...",
                       Toast.LENGTH_SHORT).show();
    }
}
