package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Toast;


public class MainActivity extends Activity
{

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item)
    {
        super.onOptionsItemSelected(item);

        if(item.getItemId() == R.id.menu1)
            Toast.makeText(MainActivity.this, "Menu 1 Seçildi", Toast.LENGTH_SHORT).show();
        else if(item.getItemId() == R.id.menu2)
            Toast.makeText(MainActivity.this, "Menu 2 Seçildi", Toast.LENGTH_SHORT).show();
        else if(item.getItemId() == R.id.menu3)
            Toast.makeText(MainActivity.this, "Menu 3 Seçildi", Toast.LENGTH_SHORT).show();


        return true;
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu)
    {
        super.onCreateOptionsMenu(menu);

        getMenuInflater().inflate(R.menu.menu_main, menu);

        return true;
    }
}
