package com.example.administrator.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.CompoundButton;
import android.widget.LinearLayout;
import android.widget.RadioButton;
import android.widget.Toast;


public class MainActivity extends Activity implements CompoundButton.OnCheckedChangeListener
{
    LinearLayout mainLayout;
    RadioButton rdErkek, rdKadın, rdDiger;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        mainLayout = (LinearLayout)findViewById(R.id.mainLayout);
        mainLayout.setBackgroundColor(getResources().getColor(R.color.colorErkek));

        rdErkek = (RadioButton)findViewById(R.id.rdErkek);
        rdKadın = (RadioButton)findViewById(R.id.rdKadın);
        rdDiger = (RadioButton)findViewById(R.id.rdDiger);

        rdErkek.setOnCheckedChangeListener(this);
        rdKadın.setOnCheckedChangeListener(this);
        rdDiger.setOnCheckedChangeListener(this);
    }

    @Override
    public void onCheckedChanged(CompoundButton buttonView, boolean isChecked)
    {
        if(buttonView.isChecked())//if(isChecked)
        {
            if(buttonView.getId() == R.id.rdErkek) {
                Toast.makeText(MainActivity.this,
                        "Erkek Seçildi...",
                        Toast.LENGTH_SHORT).show();
                mainLayout.setBackgroundColor(getResources().getColor(R.color.colorErkek));
            }
            else if(buttonView.getId() == R.id.rdKadın) {
                Toast.makeText(MainActivity.this,
                        "Kadın Seçildi...",
                        Toast.LENGTH_SHORT).show();
                mainLayout.setBackgroundColor(getResources().getColor(R.color.colorKadın));
            }
            else if(buttonView.getId() == R.id.rdDiger) {
                Toast.makeText(MainActivity.this,
                        "Diğer Seçildi...",
                        Toast.LENGTH_SHORT).show();
                mainLayout.setBackgroundColor(getResources().getColor(R.color.colorDiger));
            }
        }
    }
}
