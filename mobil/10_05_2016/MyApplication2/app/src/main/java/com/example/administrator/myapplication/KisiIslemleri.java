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
    Context context;
    myDataBaseHelper helper;

    public KisiIslemleri(Context context)
    {
        this.context = context;
        helper = new myDataBaseHelper(context);
    }

    public ArrayList<Kisi> Listele()
    {
        String[] listelenecek_alanlar = {myDataBaseHelper.COL_TBLKISILER_ID,
                                         myDataBaseHelper.COL_TBLKISILER_AD,
                                         myDataBaseHelper.COL_TBLKISILER_SOYAD,
                                         myDataBaseHelper.COL_TBLKISILER_TELNO,
                                         myDataBaseHelper.COL_TBLKISILER_CINSIYET};

        SQLiteDatabase db = helper.getReadableDatabase();
        Cursor cursor = db.query(myDataBaseHelper.TABLENAME_KISILER, listelenecek_alanlar, null, null, null, null, null);

        ArrayList<Kisi> kisiler = new ArrayList<Kisi>();
        while (cursor.moveToNext())
        {
            int id = cursor.getInt(cursor.getColumnIndex(myDataBaseHelper.COL_TBLKISILER_ID));
            String ad = cursor.getString(cursor.getColumnIndex(myDataBaseHelper.COL_TBLKISILER_AD));
            String soyad = cursor.getString(cursor.getColumnIndex(myDataBaseHelper.COL_TBLKISILER_SOYAD));
            String telno = cursor.getString(cursor.getColumnIndex(myDataBaseHelper.COL_TBLKISILER_TELNO));
            int cinsiyet = cursor.getInt(cursor.getColumnIndex(myDataBaseHelper.COL_TBLKISILER_CINSIYET));
            Kisi kisi = new Kisi(id, ad, soyad, telno, cinsiyet);
            kisiler.add(kisi);
        }
        return kisiler;
    }

    public int Ekle(Kisi kisi)
    {
        SQLiteDatabase db = helper.getWritableDatabase();
        ContentValues cv = new ContentValues();
        cv.put(myDataBaseHelper.COL_TBLKISILER_AD, kisi.getAd());
        cv.put(myDataBaseHelper.COL_TBLKISILER_SOYAD, kisi.getSoyad());
        cv.put(myDataBaseHelper.COL_TBLKISILER_TELNO, kisi.getTelNo());
        cv.put(myDataBaseHelper.COL_TBLKISILER_CINSIYET, kisi.getCinsiyet());

        int id = (int)db.insertOrThrow(myDataBaseHelper.TABLENAME_KISILER, null, cv);
        return  id;
    }

    public void Sil(Kisi kisi)
    {
        SQLiteDatabase db = helper.getWritableDatabase();
        String Where = myDataBaseHelper.COL_TBLKISILER_ID + " = " + kisi.getId();
        db.delete(myDataBaseHelper.TABLENAME_KISILER,Where, null);
    }

    public void Guncelle(Kisi kisi)
    {
        SQLiteDatabase db = helper.getWritableDatabase();
        String Where = myDataBaseHelper.COL_TBLKISILER_ID + " = " + kisi.getId();
        ContentValues cv = new ContentValues();
        cv.put(myDataBaseHelper.COL_TBLKISILER_AD, kisi.getAd());
        cv.put(myDataBaseHelper.COL_TBLKISILER_SOYAD, kisi.getSoyad());
        cv.put(myDataBaseHelper.COL_TBLKISILER_TELNO, kisi.getTelNo());
        cv.put(myDataBaseHelper.COL_TBLKISILER_CINSIYET, kisi.getCinsiyet());

        db.update(myDataBaseHelper.TABLENAME_KISILER,cv, Where, null);
    }
}
