package com.example.cemreeryilmaz.myapplication;

/**
 * Created by cemreeryilmaz on 24.05.2016.
 */
public class Kitap
{
    private int kitapid;
    private String yazarAd;
    private String kitapAd;

    public Kitap(int kitapid,String yazarAd,String kitapAd){
        this.setKitapid(kitapid);
        this.setYazarAd(yazarAd);
        this.setKitapAd(kitapAd);
    }

    public Kitap(String yazarAd,String kitapAd){
        this.setKitapid(-1);
        this.setYazarAd(yazarAd);
        this.setKitapAd(kitapAd);
    }

    public int getKitapid() {
        return kitapid;
    }

    public void setKitapid(int kitapid) {
        this.kitapid = kitapid;
    }

    public String getYazarAd() {
        return yazarAd;
    }

    public void setYazarAd(String yazarAd) {
        this.yazarAd = yazarAd;
    }

    public String getKitapAd() {
        return kitapAd;
    }

    public void setKitapAd(String kitapAd) {
        this.kitapAd = kitapAd;
    }
}
