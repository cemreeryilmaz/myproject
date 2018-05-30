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
import android.widget.Spinner;
import android.widget.Toast;

import java.util.ArrayList;


public class MainActivity extends Activity {

    private final static int CONTEXTMENU_SIL_ID = Menu.FIRST;
    private final static int CONTEXTMENU_DUZENLE_ID = Menu.FIRST + 1;

    private final static int OPTIONMENU_EKLE_ID = Menu.FIRST;


    ListView lstKisiler;
    ArrayList<Kisi> Kisiler;
    myKisiAdapter adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        Kisiler = new ArrayList<Kisi>();
        Kisiler.add(new Kisi(Kisi.CINSIYET_ERKEK, "Kemalettin", "Kamiloğlu"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_ERKEK, "Cemalettin", "Yeşil"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_KADIN, "Safiye", "Lacivert"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_KADIN, "Necmiye", "Morcivert"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_ERKEK, "Muhittin", "Mahmutoğlu"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_ERKEK, "Fıdıl", "Fındık"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_KADIN, "Şukufe", "Sarı"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_ERKEK, "Necmettin", "Kırmızı"));
        Kisiler.add(new Kisi(Kisi.CINSIYET_ERKEK, "Safettin", "Beyaz"));


        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        adapter = new myKisiAdapter(MainActivity.this, R.layout.my_listview_item, Kisiler);

        lstKisiler = (ListView)findViewById(R.id.lstKisiler);
        lstKisiler.setAdapter(adapter);

        registerForContextMenu(lstKisiler);
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo)
    {
        super.onCreateContextMenu(menu, v, menuInfo);

        menu.add(Menu.NONE, CONTEXTMENU_SIL_ID, 0, "Sil");
        menu.add(Menu.NONE, CONTEXTMENU_DUZENLE_ID, 1, "Düzenle");
    }

    @Override
    public boolean onContextItemSelected(MenuItem item)
    {
        AdapterView.AdapterContextMenuInfo info = (AdapterView.AdapterContextMenuInfo)item.getMenuInfo();

        if(item.getItemId() == CONTEXTMENU_SIL_ID) {
            Kisi kisi = adapter.getItem(info.position);
            Toast.makeText(MainActivity.this, kisi.getAd()+" "+kisi.getSoyad() + " Silinmek İstendi...", Toast.LENGTH_SHORT).show();
            //Silme İşlemi
            adapter.remove(kisi);
            adapter.notifyDataSetChanged();
        }
        else {
            if (item.getItemId() == CONTEXTMENU_DUZENLE_ID) {
                final Kisi kisi = adapter.getItem(info.position);

                final Dialog kisi_dialog = new Dialog(MainActivity.this);
                kisi_dialog.setContentView(R.layout.kisi_dialog_layout);
                kisi_dialog.setCancelable(false);
                kisi_dialog.setTitle("Kişi Düzenle");

                final EditText edtAd = (EditText) kisi_dialog.findViewById(R.id.edtAd);
                final EditText edtSoyad = (EditText) kisi_dialog.findViewById(R.id.edtSoyad);
                final RadioButton rdErkek = (RadioButton) kisi_dialog.findViewById(R.id.rdErkek);
                final RadioButton rdKadın = (RadioButton) kisi_dialog.findViewById(R.id.rdKadın);

                edtAd.setText(kisi.getAd());
                edtSoyad.setText(kisi.getSoyad());

                if (kisi.getCinsiyet() == Kisi.CINSIYET_ERKEK)
                    rdErkek.setChecked(true);
                else if (kisi.getCinsiyet() == Kisi.CINSIYET_KADIN)
                    rdKadın.setChecked(true);

                kisi_dialog.show();

                Button btnTamam = (Button) kisi_dialog.findViewById(R.id.btnTamam);
                Button btnIptal = (Button) kisi_dialog.findViewById(R.id.btnIptal);

                btnIptal.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {
                        Toast.makeText(MainActivity.this, "İptal Edildi...", Toast.LENGTH_SHORT).show();
                        kisi_dialog.dismiss();//dialog kapama
                    }
                });

                btnTamam.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {
                        kisi.setAd(edtAd.getText().toString());
                        kisi.setSoyad(edtSoyad.getText().toString());
                        if(rdErkek.isChecked())
                            kisi.setCinsiyet(Kisi.CINSIYET_ERKEK);
                        else if(rdKadın.isChecked())
                            kisi.setCinsiyet(Kisi.CINSIYET_KADIN);

                        adapter.notifyDataSetChanged();

                        kisi_dialog.dismiss();
                    }
                });
            }
        }

        return super.onContextItemSelected(item);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {

        MenuItem item = menu.add(Menu.NONE, OPTIONMENU_EKLE_ID,0,"Ekle");
        item.setShowAsAction(MenuItem.SHOW_AS_ACTION_ALWAYS);
        item.setIcon(getResources().getDrawable(R.drawable.add_ico));

        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {

        if(item.getItemId() == OPTIONMENU_EKLE_ID)
        {
            final Dialog dialog_kisi = new Dialog(MainActivity.this);
            dialog_kisi.setContentView(R.layout.kisi_dialog_layout);
            dialog_kisi.setCancelable(false);
            dialog_kisi.setTitle("Kişi Ekle");

            dialog_kisi.show();

            final EditText edtAd = (EditText)dialog_kisi.findViewById(R.id.edtAd);
            final EditText edtSoyad = (EditText)dialog_kisi.findViewById(R.id.edtSoyad);
            final RadioButton rdErkek = (RadioButton)dialog_kisi.findViewById(R.id.rdErkek);
            RadioButton rdKadın = (RadioButton)dialog_kisi.findViewById(R.id.rdKadın);
            Button btnTamam = (Button)dialog_kisi.findViewById(R.id.btnTamam);
            Button btnIptal = (Button)dialog_kisi.findViewById(R.id.btnIptal);

            btnIptal.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Toast.makeText(MainActivity.this, "İptal Edildi...", Toast.LENGTH_SHORT).show();
                    dialog_kisi.dismiss();
                }
            });

            btnTamam.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Kisi kisi = new Kisi((rdErkek.isChecked())?Kisi.CINSIYET_ERKEK : Kisi.CINSIYET_KADIN, edtAd.getText().toString(), edtSoyad.getText().toString());
                    adapter.add(kisi);
                    adapter.notifyDataSetChanged();
                    dialog_kisi.dismiss();
                }
            });
        }

        return super.onOptionsItemSelected(item);
    }
}
