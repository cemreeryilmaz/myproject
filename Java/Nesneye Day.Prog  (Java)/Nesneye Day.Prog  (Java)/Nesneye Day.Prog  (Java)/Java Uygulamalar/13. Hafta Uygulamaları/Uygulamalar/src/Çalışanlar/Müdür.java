package Çalýþanlar;

public class Müdür extends Çalýþan{
	String görevi="Müdür";
	public Müdür(int sicilno, String ad, String soyad, double maaþ) {
		super(sicilno, ad, soyad, maaþ);
	}
	
	public void konuþ(){
		System.out.println("Merhaba ben Müdür");
	}
}
