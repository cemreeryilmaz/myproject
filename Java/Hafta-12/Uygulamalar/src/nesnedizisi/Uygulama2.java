package nesnedizisi;

import java.util.Scanner;

import thisvesuperkullanýmý.Asker;

public class Uygulama2 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		Asker asker=new Asker(2000, "Havacý", "Ahmet Yýlmaz");
		Çalýþan []çalýþanlar=new Çalýþan[3];
		çalýþanlar[0]=new Çalýþan();
		çalýþanlar[1]=new Memur();
		çalýþanlar[2]=new Öðretmen();
		//çalýþanlar[0].çalýþ();
		çalýþanlar[0].adsoyad="Ahmet Yýlmaz";
		çalýþanlar[0].maaþ=1500;
		çalýþanlar[0].sicilno=1234;
		//-----------------------------------------------------
		çalýþanlar[1].adsoyad="Mehmet Yýlmaz";
		çalýþanlar[1].maaþ=2500;
		çalýþanlar[1].sicilno=1235;
		//-----------------------------------------------------
		çalýþanlar[2].adsoyad="Savaþ Yýlmaz";
		çalýþanlar[2].maaþ=3000;
		çalýþanlar[2].sicilno=1236;
		//-----------------------------------------------------
		/*Memur yenimemur=(Memur) çalýþanlar[1];//Aþaðý çevrim
		Öðretmen yeniöðretmen=(Öðretmen)çalýþanlar[2];//Aþaðý çevrim
		yenimemur.bilgiVer();
		yeniöðretmen.bilgiVer();*/	
		/*for (int i = 0; i < çalýþanlar.length; i++) {
			çalýþanlar[i].çalýþ();
		}*/
		hepsiniÇalýþtýr(çalýþanlar);
	}

	private static void hepsiniÇalýþtýr(Çalýþan[] çalýþanlar) {
		for (int i = 0; i < çalýþanlar.length; i++) {
			çalýþanlar[i].çalýþ();
		}
		
	}
}
