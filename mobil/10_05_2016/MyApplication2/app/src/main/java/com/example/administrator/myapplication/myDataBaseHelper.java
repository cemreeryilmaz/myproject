package com.example.administrator.myapplication;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by Administrator on 10.05.2016.
 */
public class myDataBaseHelper extends SQLiteOpenHelper
{
    public static final String DB_NAME = "db_kisiler";
    public static final String TABLENAME_KISILER = "tblKisiler";
    public static final String COL_TBLKISILER_ID = "id";
    public static final String COL_TBLKISILER_AD = "ad";
    public static final String COL_TBLKISILER_SOYAD = "soyad";
    public static final String COL_TBLKISILER_TELNO = "telno";
    public static final String COL_TBLKISILER_CINSIYET = "cinsiyet";
    public static final int DB_VER = 1;

    public static final String CREATE_TABLE_KISILER ="CREATE TABLE "+TABLENAME_KISILER+"("+
            COL_TBLKISILER_ID+" INTEGER PRIMARY KEY AUTOINCREMENT,"+
            COL_TBLKISILER_AD+" TEXT,"+
            COL_TBLKISILER_SOYAD+" TEXT,"+
            COL_TBLKISILER_TELNO+" TEXT,"+
            COL_TBLKISILER_CINSIYET+" INTEGER);";

    public static final String DROP_TABLE_KISILER ="DROP TABLE IF EXISTS "+TABLENAME_KISILER;


    public myDataBaseHelper(Context context)
    {
        super(context, DB_NAME, null, DB_VER);
    }

    @Override
    public void onCreate(SQLiteDatabase db)
    {
         db.execSQL(CREATE_TABLE_KISILER);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
    {
        db.execSQL(DROP_TABLE_KISILER);
        onCreate(db);
    }
}
