package Çalýþanlar;

public class Çalýþan {
protected int sicilno;
public String ad="Çalýþan Kiþi";
private String soyad;
double maaþ;


public String getSoyad() {
	return soyad;
}
public void setSoyad(String soyad) {
	this.soyad = soyad;
}
public Çalýþan(int sicilno, String ad, String soyad, double maaþ) {
	this.sicilno = sicilno;
	this.ad = ad;
	this.soyad = soyad;
	this.maaþ = maaþ;
}
public void çalýþ(int saat){
	System.out.println("Çalýþan "+ saat+" saat çalýþtý.");
}
public void konuþ(){
	System.out.println("Merhaba ben Çalýþan");
}

}
