package Çalýþanlar;

public class Uygulama1 {

	public static void main(String[] args) {
		Çalýþan ahmet=new Çalýþan();
		ahmet.adres.kapýno=10;
		Müdür mehmet=new Müdür();
		mehmet.adres.cadde="Halkalý caddesi";
		//Çalýþan sýnýfýnýn içinde Adres sýnýfýna ait bir nesne
		//olduðu için Çalýþan sýnýfý ile Adres sýnýfý arasýnda
		//sahip olma (HAS-A) iliþkisi vardýr. Buna kompozisyon
		// da denir.
	}
}
