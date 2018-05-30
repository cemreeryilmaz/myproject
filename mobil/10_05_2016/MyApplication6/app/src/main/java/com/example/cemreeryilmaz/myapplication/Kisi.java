package com.example.cemreeryilmaz.myapplication;

/**
 * Created by cemreeryilmaz on 22.05.2016.
 */
public class Kisi
{
    private int id;
    private String ad;
    private String soyad;

    public Kisi(int id,String ad,String soyad){
        this.setId(id);
        this.setAd(ad);
        this.setSoyad(soyad);
    }

    public Kisi(String ad,String soyad){
        this.setId(-1);
        this.setAd(ad);
        this.setSoyad(soyad);
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getAd() {
        return ad;
    }

    public void setAd(String ad) {
        this.ad = ad;
    }

    public String getSoyad() {
        return soyad;
    }

    public void setSoyad(String soyad) {
        this.soyad = soyad;
    }
}
