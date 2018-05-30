package com.example.administrator.myapplication;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by Administrator on 10.05.2016.
 */
public class myDatabaseHelper extends SQLiteOpenHelper
{
    public static final String DB_NAME = "database1";
    public static final String TABLE_NAME = "Kisiler";
    public static final String COL_ID = "id";
    public static final String COL_AD = "ad";
    public static final String COL_SOYAD = "soyad";
    public static final int DB_VER = 1;

    private static final String TABLE_CREATE = "CREATE TABLE "+TABLE_NAME+"("+
            COL_ID+" INTEGER PRIMARY KEY AUTOINCREMENT,"+
            COL_AD+" TEXT,"+
            COL_SOYAD+" TEXT);";

    private static final String DROP_TABLE = "DROP TABLE IF EXISTS "+TABLE_NAME;

    public myDatabaseHelper(Context context)
    {
        //database oluşturulur
        super(context, DB_NAME, null, DB_VER);
    }

    @Override
    public void onCreate(SQLiteDatabase db)
    {
        //tablolarımızı oluştururuz...
        db.execSQL(TABLE_CREATE);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
    {
        db.execSQL(DROP_TABLE);
        onCreate(db);
    }
}
