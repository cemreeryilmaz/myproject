package com.example.cemreeryilmaz.myapplication;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by cemreeryilmaz on 22.05.2016.
 */
public class MyDatabaseHelper extends SQLiteOpenHelper{

    public static final int DB_VER = 1;
    public static final String DB_NAME = "db_kisiler";
    public static final String TABLE_NAME = "Kisiler";

    public static final String COL_ID = "id";
    public static final String COL_AD = "ad";
    public static final String COL_SOYAD = "soyad";

    public static final String CREATE_TABLE = "CREATE TABLE " + TABLE_NAME + "(" + COL_ID + " INTEGER PRIMARY KEY AUTOINCREMENT " +
            COL_AD + " TEXT " + COL_SOYAD + " TEXT);";
    public static final String DROP_TABLE = "DROP TABLE IF EXISTS " + TABLE_NAME

    public MyDatabaseHelper(Context context) {
        super(context, DB_NAME, null, DB_VER);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(CREATE_TABLE);

    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL(DROP_TABLE);
        onCreate(db);

    }
}
