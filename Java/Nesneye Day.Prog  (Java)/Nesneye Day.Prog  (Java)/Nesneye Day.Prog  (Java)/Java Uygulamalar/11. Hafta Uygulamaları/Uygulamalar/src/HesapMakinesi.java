import java.awt.Color;

public class HesapMakinesi {
	
	Color renk;
	int tuşsayısı;
	String şekil;
	int digitsayısı;
	
	public double toplamaYap(double sayı1,double sayı2){
		return sayı1+sayı2;
	}
	public double çıkarmaYap(double sayı1,double sayı2){
		return sayı1-sayı2;
	}
	public double çarpmaYap(double sayı1,double sayı2){
		return sayı1*sayı2;
	}
	public double bölmeYap(double sayı1,double sayı2){
		return sayı1/sayı2;
	}
}
