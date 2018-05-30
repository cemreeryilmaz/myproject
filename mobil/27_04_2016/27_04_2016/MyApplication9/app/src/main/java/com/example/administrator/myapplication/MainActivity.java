package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Toast;


public class MainActivity extends Activity
{

    static int Menu1_ID = Menu.FIRST;
    static int Menu2_ID = Menu.FIRST + 1;
    static int Menu3_ID = Menu.FIRST + 2;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu)
    {
        menu.add(Menu.NONE, Menu1_ID, 0, "Menü 1");
        menu.add(Menu.NONE, Menu2_ID, 1, "Menü 2");

        MenuItem item_menu3 = menu.add(Menu.NONE, Menu3_ID, 2, "Menü 3");
        item_menu3.setShowAsAction(MenuItem.SHOW_AS_ACTION_ALWAYS);
        item_menu3.setIcon(getResources().getDrawable(R.drawable.ic_launcher));

        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {

        switch (item.getItemId())
        {
            case Menu.FIRST:
                Toast.makeText(MainActivity.this, "Menu 1 Seçildi", Toast.LENGTH_SHORT).show();
                return  true;
            case Menu.FIRST + 1:
                Toast.makeText(MainActivity.this, "Menu 2 Seçildi", Toast.LENGTH_SHORT).show();
                return  true;
            case Menu.FIRST + 2:
                Toast.makeText(MainActivity.this, "Menu 3 Seçildi", Toast.LENGTH_SHORT).show();
                return  true;
        }

        return super.onOptionsItemSelected(item);
    }
}
