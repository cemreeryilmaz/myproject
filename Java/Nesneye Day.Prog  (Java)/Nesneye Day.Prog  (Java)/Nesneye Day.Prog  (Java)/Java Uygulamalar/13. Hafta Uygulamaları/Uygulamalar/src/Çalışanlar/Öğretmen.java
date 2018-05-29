package Çalýþanlar;

public class Öðretmen extends Çalýþan{
	String görevi="Öðretmen";	
	public Öðretmen(int sicilno, String ad, String soyad, double maaþ) {
		super(sicilno,ad,soyad,maaþ);
	}	
	public void adSöyle(){
		System.out.println(this.ad);
		System.out.println(super.ad);
	}
	public void çalýþtýr(int saat){
		super.çalýþ(saat);
	}
	public void konuþ(){
		System.out.println("Merhaba ben Öðretmen");
	}
}
