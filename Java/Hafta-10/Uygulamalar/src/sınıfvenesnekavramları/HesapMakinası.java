package sınıfvenesnekavramları;

import java.awt.Color;

public class HesapMakinası {
	
	String şekil;
	int digitsayısı;
	int tuşsayısı;
	Color renk;
	
	public HesapMakinası(String ş,int d,int t,Color r){
		şekil=ş;
		digitsayısı=d;
		tuşsayısı=t;
		renk=r;
	}
	public double toplamaYap(double sayı1,double sayı2){
		return sayı1+sayı2;
	}
	public double çıkarmaYap(double sayı1,double sayı2){
		return sayı1-sayı2;
	}
	public double bölmeYap(double sayı1,double sayı2){
		return sayı1/sayı2;
	}
	public double çarpmaYap(double sayı1,double sayı2){
		return sayı1*sayı2;
	}
}
