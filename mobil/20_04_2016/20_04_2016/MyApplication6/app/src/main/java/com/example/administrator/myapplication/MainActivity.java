package com.example.administrator.myapplication;

import android.app.Activity;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;


public class MainActivity extends Activity
{
    ImageView imgView;

    Drawable[] resimler;

    int index = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        resimler = new Drawable[]{getResources().getDrawable(R.drawable.koala),
                                    getResources().getDrawable(R.drawable.penguins),
                                    getResources().getDrawable(R.drawable.lighthouse),
                                    getResources().getDrawable(R.drawable.tulips)};

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        imgView = (ImageView)findViewById(R.id.imageView);
        imgView.setImageDrawable(resimler[index]);
    }

    public void btnIleri_Click(View v)
    {
        index++;
        if(index == 4)
            index = 0;

        imgView.setImageDrawable(resimler[index]);

    }

    public void btnGeri_Click(View v)
    {
        index--;
        if(index == -1)
            index = 3;

        imgView.setImageDrawable(resimler[index]);
    }
}
