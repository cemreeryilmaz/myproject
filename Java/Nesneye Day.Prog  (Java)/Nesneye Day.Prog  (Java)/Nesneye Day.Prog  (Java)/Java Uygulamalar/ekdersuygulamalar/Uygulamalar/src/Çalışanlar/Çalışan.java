package Çalýþanlar;

public class Çalýþan {
	
	int sigortano;
	String ad;
	String soyad;
	double maaþ;
	Adres adres=new Adres();
	String tcno;
	
	public void çalýþ(){
		System.out.println("Çalýþan sýnýfý çalýþtý.");
	}
	public final void konuþ(){
		System.out.println("Merhaba ben çalýþan.");
	}

}
