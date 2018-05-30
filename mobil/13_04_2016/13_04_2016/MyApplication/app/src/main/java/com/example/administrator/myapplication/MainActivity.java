package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;


public class MainActivity extends Activity implements View.OnClickListener {

    Button btnArtır;
    Button btnAzalt;
    Button btnSıfırla;
    TextView txtSayac;

    int sayac = 0;

    View.OnClickListener btnAzaltOnClickListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            sayac--;
            txtSayac.setText(String.valueOf(sayac));
        }
    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        txtSayac = (TextView)findViewById(R.id.txtSayac);
        btnArtır = (Button)findViewById(R.id.btnArtır);
        btnAzalt = (Button)findViewById(R.id.btnAzalt);
        btnSıfırla = (Button)findViewById(R.id.btnSıfırla);

        btnSıfırla.setOnClickListener(this);

        btnAzalt.setOnClickListener(btnAzaltOnClickListener);

        btnArtır.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                sayac++;
                txtSayac.setText(String.valueOf(sayac));
            }
        });
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @Override
    public void onClick(View v) {
        sayac = 0;
        txtSayac.setText(String.valueOf(sayac));
    }
}
