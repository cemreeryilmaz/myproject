package com.example.administrator.myapplication;

/**
 * Created by Administrator on 10.05.2016.
 */
public class Kisi
{
    public static final int CINSIYET_ERKEK = 1;
    public static final int CINSIYET_KADIN = 2;

    private int id;
    private String ad;
    private String soyad;
    private String telNo;
    private int cinsiyet;

    public Kisi(int id, String ad, String soyad, String telNo, int cinsiyet)
    {
        this.setId(id);
        this.setAd(ad);
        this.setSoyad(soyad);
        this.setTelNo(telNo);
        this.setCinsiyet(cinsiyet);
    }

    public Kisi(String ad, String soyad, String telNo, int cinsiyet)
    {
        this.setId(-1);
        this.setAd(ad);
        this.setSoyad(soyad);
        this.setTelNo(telNo);
        this.setCinsiyet(cinsiyet);
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

    public String getTelNo() {
        return telNo;
    }

    public void setTelNo(String telNo) {
        this.telNo = telNo;
    }

    public int getCinsiyet() {
        return cinsiyet;
    }

    public void setCinsiyet(int cinsiyet) {
        this.cinsiyet = cinsiyet;
    }
}
