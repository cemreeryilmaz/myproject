package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;


public class MainActivity extends Activity
{
    EditText edtAdSoyad;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        edtAdSoyad = (EditText)findViewById(R.id.editText1);
    }

    public void btnTamam_Click(View v)
    {
        if(edtAdSoyad.getText().toString().trim().isEmpty()) {
            Toast.makeText(MainActivity.this, "Herhangi bir şey girilmedi...", Toast.LENGTH_SHORT).show();
            edtAdSoyad.setError("Boş Bırakılamaz!!!");
        }
        else {
            Toast.makeText(MainActivity.this, "Adınız : " + edtAdSoyad.getText(), Toast.LENGTH_SHORT).show();
        }
    }
}
