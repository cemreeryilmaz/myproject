package com.example.administrator.myapplication;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

import java.util.ArrayList;

/**
 * Created by Administrator on 10.05.2016.
 */
public class KisiIslemleri
{
    SQLiteDatabase my_db;
    myDatabaseHelper helper;
    String[] alan_isimleri = {myDatabaseHelper.COL_ID,
                              myDatabaseHelper.COL_AD,
                              myDatabaseHelper.COL_SOYAD};

    public KisiIslemleri(Context context)
    {
        helper = new myDatabaseHelper(context);
    }

    public ArrayList<Kisi> Listele()
    {
        ArrayList<Kisi> kisiler = new ArrayList<Kisi>();
        my_db = helper.getReadableDatabase();
        Cursor cursor = my_db.query(myDatabaseHelper.TABLE_NAME,
                                    alan_isimleri,
                                    null,null,null,null,null);

        while (cursor.moveToNext())
        {
            int id = cursor.getInt(cursor.getColumnIndex(myDatabaseHelper.COL_ID));
            String ad = cursor.getString(cursor.getColumnIndex(myDatabaseHelper.COL_AD));
            String soyad = cursor.getString(cursor.getColumnIndex(myDatabaseHelper.COL_SOYAD));

            Kisi kisi = new Kisi(id, ad, soyad);
            kisiler.add(kisi);
        }
        return kisiler;
    }

    public long Ekle(Kisi kisi)
    {
        my_db = helper.getWritableDatabase();

        ContentValues cv = new ContentValues();
        cv.put(myDatabaseHelper.COL_AD, kisi.getAd());
        cv.put(myDatabaseHelper.COL_SOYAD, kisi.getSoyad());

        long id = my_db.insertOrThrow(myDatabaseHelper.TABLE_NAME,
                                      null, cv);

        return id;
    }

    public void Sil(Kisi kisi)
    {
        my_db = helper.getWritableDatabase();
        String Where = myDatabaseHelper.COL_ID+"="+kisi.getId();
        my_db.delete(myDatabaseHelper.TABLE_NAME,Where, null);
    }

    public void Guncelle(Kisi kisi)
    {
        ContentValues cv = new ContentValues();
        cv.put(myDatabaseHelper.COL_AD, kisi.getAd());
        cv.put(myDatabaseHelper.COL_SOYAD, kisi.getSoyad());

        String Where = myDatabaseHelper.COL_ID+"="+kisi.getId();

        my_db = helper.getWritableDatabase();
        my_db.update(myDatabaseHelper.TABLE_NAME, cv, Where, null);
    }
}
