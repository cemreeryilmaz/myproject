package com.example.administrator.myapplication;

/**
 * Created by Administrator on 04.05.2016.
 */
public class Kisi
{
    public final static int CINSIYET_ERKEK = 0;
    public final static int CINSIYET_KADIN = 1;

    private int cinsiyet;
    private String ad;
    private String soyad;

    public Kisi(int cinsiyet, String ad, String soyad)
    {
        this.setCinsiyet(cinsiyet);
        this.setAd(ad);
        this.setSoyad(soyad);
    }

    public int getCinsiyet() {
        return cinsiyet;
    }

    public void setCinsiyet(int cinsiyet) {
        this.cinsiyet = cinsiyet;
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
