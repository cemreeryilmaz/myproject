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
import android.widget.RadioButton;

import java.util.ArrayList;


public class MainActivity extends Activity
{
    public static final int OP_MENU_EKLE_ID = Menu.FIRST;
    public static final int CON_MENU_SIL_ID = Menu.FIRST;
    public static final int CON_MENU_GUNCELLE_ID = Menu.FIRST + 1;

    KisiIslemleri kisiIslemleri;
    ArrayList<Kisi> Kisiler;
    KisiAdapter adapter;
    ListView lstKisiler;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        kisiIslemleri = new KisiIslemleri(MainActivity.this);
        Kisiler = kisiIslemleri.Listele();
        adapter = new KisiAdapter(MainActivity.this,R.layout.kisi_layout, Kisiler);
        lstKisiler = (ListView)findViewById(R.id.lsKisiler);
        lstKisiler.setAdapter(adapter);

        registerForContextMenu(lstKisiler);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu)
    {
        MenuItem item = menu.add(Menu.NONE,OP_MENU_EKLE_ID, 0, "Ekle");
        item.setShowAsAction(MenuItem.SHOW_AS_ACTION_ALWAYS);
        item.setIcon(getResources().getDrawable(R.drawable.add));
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item)
    {
        if(item.getItemId() == OP_MENU_EKLE_ID)
        {
            final Dialog dialog = new Dialog(MainActivity.this);
            dialog.setTitle("Kişi Ekle");
            dialog.setCancelable(false);
            dialog.setContentView(R.layout.kisi_dialog_layout);

            dialog.show();

            final EditText edtAd = (EditText)dialog.findViewById(R.id.edtAd);
            final EditText edtSoyad = (EditText)dialog.findViewById(R.id.edtSoyad);
            final EditText edtTelNo = (EditText)dialog.findViewById(R.id.edtTelNo);
            final RadioButton rdErkek = (RadioButton)dialog.findViewById(R.id.rdErkek);
            RadioButton rdKadın = (RadioButton)dialog.findViewById(R.id.rdKadın);
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
                    Kisi kisi = new Kisi(edtAd.getText().toString(),
                                         edtSoyad.getText().toString(),
                                         edtTelNo.getText().toString(),
                                        (rdErkek.isChecked())?Kisi.CINSIYET_ERKEK : Kisi.CINSIYET_KADIN);
                    int id = kisiIslemleri.Ekle(kisi);
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

        menu.add(Menu.NONE, CON_MENU_SIL_ID, 0, "Sil");
        menu.add(Menu.NONE, CON_MENU_GUNCELLE_ID, 1, "Güncelle");
    }

    @Override
    public boolean onContextItemSelected(MenuItem item)
    {
        AdapterView.AdapterContextMenuInfo info = (AdapterView.AdapterContextMenuInfo)item.getMenuInfo();
        final Kisi kisi = adapter.getItem(info.position);

        if(item.getItemId() == CON_MENU_SIL_ID)
        {
            kisiIslemleri.Sil(kisi);
            adapter.remove(kisi);
            adapter.notifyDataSetChanged();
        }
        else if(item.getItemId() == CON_MENU_GUNCELLE_ID)
        {
            final Dialog dialog = new Dialog(MainActivity.this);
            dialog.setTitle("Kişi Güncelle");
            dialog.setCancelable(false);
            dialog.setContentView(R.layout.kisi_dialog_layout);



            final EditText edtAd = (EditText)dialog.findViewById(R.id.edtAd);
            final EditText edtSoyad = (EditText)dialog.findViewById(R.id.edtSoyad);
            final EditText edtTelNo = (EditText)dialog.findViewById(R.id.edtTelNo);
            final RadioButton rdErkek = (RadioButton)dialog.findViewById(R.id.rdErkek);
            RadioButton rdKadın = (RadioButton)dialog.findViewById(R.id.rdKadın);
            Button btnTamam = (Button)dialog.findViewById(R.id.btnTamam);
            Button btnIptal = (Button)dialog.findViewById(R.id.btnIptal);

            edtAd.setText(kisi.getAd());
            edtSoyad.setText(kisi.getSoyad());
            edtTelNo.setText(kisi.getTelNo());

            if(kisi.getCinsiyet() == Kisi.CINSIYET_ERKEK)
                rdErkek.setChecked(true);
            else
                rdKadın.setChecked(true);

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
                   kisi.setTelNo(edtTelNo.getText().toString());
                   kisi.setCinsiyet((rdErkek.isChecked())?Kisi.CINSIYET_ERKEK : Kisi.CINSIYET_KADIN);

                   kisiIslemleri.Guncelle(kisi);
                    adapter.notifyDataSetChanged();
                    dialog.dismiss();
                }
            });
        }

        return super.onContextItemSelected(item);
    }
}
