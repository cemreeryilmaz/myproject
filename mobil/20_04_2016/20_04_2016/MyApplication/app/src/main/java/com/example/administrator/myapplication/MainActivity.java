package com.example.administrator.myapplication;

import android.app.Activity;
import android.graphics.Color;
import android.os.Bundle;
import android.widget.CompoundButton;
import android.widget.LinearLayout;
import android.widget.RadioButton;


public class MainActivity extends Activity implements CompoundButton.OnCheckedChangeListener
{
    LinearLayout mainLayuout;
    RadioButton rdKırmızı, rdYesil, rdMavi;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        mainLayuout = (LinearLayout)findViewById(R.id.mainLayout);
        rdKırmızı = (RadioButton)findViewById(R.id.rdKırmızı);
        rdMavi = (RadioButton)findViewById(R.id.rdMavi);
        rdYesil = (RadioButton)findViewById(R.id.rdYesil);

        rdYesil.setOnCheckedChangeListener(this);
        rdMavi.setOnCheckedChangeListener(this);
        rdKırmızı.setOnCheckedChangeListener(this);
    }

    @Override
    public void onCheckedChanged(CompoundButton buttonView, boolean isChecked)
    {
        if(isChecked)
        {
            if(buttonView.getId() == R.id.rdKırmızı)
                mainLayuout.setBackgroundColor(getResources().getColor(R.color.kırmızı));
            else if(buttonView.getId() == R.id.rdMavi)
                mainLayuout.setBackgroundColor(getResources().getColor(R.color.mavi));
                //mainLayuout.setBackgroundColor(Color.BLUE);
            else if(buttonView.getId() == R.id.rdYesil)
                mainLayuout.setBackgroundColor(getResources().getColor(R.color.yesil));
                //mainLayuout.setBackgroundColor(Color.GREEN);
        }
    }
}
