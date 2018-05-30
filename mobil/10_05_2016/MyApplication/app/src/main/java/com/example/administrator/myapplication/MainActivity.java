package com.example.administrator.myapplication;

import android.app.Activity;
import android.app.Dialog;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

import java.util.ArrayList;


public class MainActivity extends Activity
{
    private static final int OPMENU_EKLE_ID = Menu.FIRST;
    private static final int CONMENU_SIL_ID = Menu.FIRST;
    private static final int CONMENU_DUZENLE_ID = Menu.FIRST + 1;


    KisiIslemleri kisiIslemleri;

    ListView lstKisiler;
    ArrayList<Kisi> Kisiler;
    KisiAdapter adapter;
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        kisiIslemleri = new KisiIslemleri(MainActivity.this);
        Kisiler = kisiIslemleri.Listele();
        adapter = new KisiAdapter(MainActivity.this, R.layout.kisi_layout, Kisiler);

        lstKisiler = (ListView)findViewById(R.id.lstKisiler);
        lstKisiler.setAdapter(adapter);

        registerForContextMenu(lstKisiler);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu)
    {
        MenuItem item = menu.add(Menu.NONE, OPMENU_EKLE_ID, 0, "EKLE");
        item.setShowAsAction(MenuItem.SHOW_AS_ACTION_ALWAYS);

        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item)
    {
        if(item.getItemId() == OPMENU_EKLE_ID)
        {
            final Dialog dialog = new Dialog(MainActivity.this);
            dialog.setCancelable(false);
            dialog.setTitle("Kişi Ekle");
            dialog.setContentView(R.layout.kisi_dialog);

            dialog.show();

            final EditText edtAd = (EditText)dialog.findViewById(R.id.edtAd);
            final EditText edtSoyad = (EditText)dialog.findViewById(R.id.edtSoyad);
            Button btnTamam = (Button)dialog.findViewById(R.id.btnTamam);
            Button btnIptal = (Button)dialog.findViewById(R.id.btnIptal);

            btnIptal.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    dialog.dismiss();
                }
            });

            btnTamam.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Kisi kisi = new Kisi(edtAd.getText().toString(), edtSoyad.getText().toString());
                    int id = (int)kisiIslemleri.Ekle(kisi);
                    kisi.setId(id);
                    adapter.add(kisi);
                    adapter.notifyDataSetChanged();
                    dialog.dismiss();
                }
            });

        }
        return super.onOptionsItemSelected(item);
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo)
    {
        super.onCreateContextMenu(menu, v, menuInfo);

        menu.add(Menu.NONE, CONMENU_SIL_ID, 0,"Sil");
        menu.add(Menu.NONE, CONMENU_DUZENLE_ID, 1,"Düzenle");
    }

    @Override
    public boolean onContextItemSelected(MenuItem item)
    {
        AdapterView.AdapterContextMenuInfo info = (AdapterView.AdapterContextMenuInfo)item.getMenuInfo();
        final Kisi kisi = adapter.getItem(info.position);

        if(item.getItemId() == CONMENU_SIL_ID)
        {
            kisiIslemleri.Sil(kisi);
            adapter.remove(kisi);
            adapter.notifyDataSetChanged();
        }
        else if(item.getItemId() == CONMENU_DUZENLE_ID)
        {
            final Dialog dialog = new Dialog(MainActivity.this);
            dialog.setTitle("Kişi Düzenle");
            dialog.setCancelable(false);
            dialog.setContentView(R.layout.kisi_dialog);

            final EditText edtAd = (EditText)dialog.findViewById(R.id.edtAd);
            final EditText edtSoyad = (EditText)dialog.findViewById(R.id.edtSoyad);
            Button btnTamam = (Button)dialog.findViewById(R.id.btnTamam);
            Button btnIptal = (Button)dialog.findViewById(R.id.btnIptal);

            edtAd.setText(kisi.getAd());
            edtSoyad.setText(kisi.getSoyad());

            dialog.show();

            btnIptal.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    dialog.dismiss();
                }
            });
            btnTamam.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    kisi.setAd(edtAd.getText().toString());
                    kisi.setSoyad(edtSoyad.getText().toString());
                    kisiIslemleri.Guncelle(kisi);
                    adapter.notifyDataSetChanged();
                    dialog.dismiss();
                }
            });

        }

        return super.onContextItemSelected(item);
    }
}
