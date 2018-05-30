package com.example.administrator.myapplication;

import android.app.Activity;
import android.graphics.Color;
import android.os.Bundle;
import android.widget.LinearLayout;
import android.widget.SeekBar;
import android.widget.TextView;


public class MainActivity extends Activity
{

    LinearLayout mainLayout;
    SeekBar sBarKırmızı, sBarYesil, sBarMavi;
    TextView txtKırmızı, txtYesil, txtMavi;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        mainLayout = (LinearLayout)findViewById(R.id.mainLayout);

        txtKırmızı = (TextView)findViewById(R.id.txtKırmızı);
        txtYesil = (TextView)findViewById(R.id.txtYesil);
        txtMavi = (TextView)findViewById(R.id.txtMavi);

        sBarKırmızı = (SeekBar)findViewById(R.id.sBarKırmızı);
        sBarYesil = (SeekBar)findViewById(R.id.sBarYesil);
        sBarMavi = (SeekBar)findViewById(R.id.sBarMavi);

        sBarKırmızı.setOnSeekBarChangeListener(sBar_Lisetener);
        sBarYesil.setOnSeekBarChangeListener(sBar_Lisetener);
        sBarMavi.setOnSeekBarChangeListener(sBar_Lisetener);

    }

    SeekBar.OnSeekBarChangeListener sBar_Lisetener = new SeekBar.OnSeekBarChangeListener() {
        @Override
        public void onProgressChanged(SeekBar seekBar, int progress, boolean fromUser) {

            mainLayout.setBackgroundColor(Color.argb(255, sBarKırmızı.getProgress(), sBarYesil.getProgress(), sBarMavi.getProgress()));

            txtKırmızı.setText(String.valueOf(sBarKırmızı.getProgress()));
            txtYesil.setText(String.valueOf(sBarYesil.getProgress()));
            txtMavi.setText(String.valueOf(sBarMavi.getProgress()));

        }

        @Override
        public void onStartTrackingTouch(SeekBar seekBar) {

        }

        @Override
        public void onStopTrackingTouch(SeekBar seekBar) {

        }
    };

}
