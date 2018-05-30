package com.example.cemreeryilmaz.myapplication;

/**
 * Created by cemreeryilmaz on 24.05.2016.
 */
public class Kullanici
{
    private int kullaniciid;
    private String kullaniciad;
    private String sifre;

    public Kullanici(int kullaniciid,String kullaniciad,String sifre){
        this.setKullaniciid(kullaniciid);
        this.setKullaniciad(kullaniciad);
        this.setSifre(sifre);
    }

    public Kullanici(String kullaniciad,String sifre){
        this.setKullaniciid(-1);
        this.setKullaniciad(kullaniciad);
        this.setSifre(sifre);
    }

    public int getKullaniciid() {
        return kullaniciid;
    }

    public void setKullaniciid(int kullaniciid) {
        this.kullaniciid = kullaniciid;
    }

    public String getKullaniciad() {
        return kullaniciad;
    }

    public void setKullaniciad(String kullaniciad) {
        this.kullaniciad = kullaniciad;
    }

    public String getSifre() {
        return sifre;
    }

    public void setSifre(String sifre) {
        this.sifre = sifre;
    }
}
