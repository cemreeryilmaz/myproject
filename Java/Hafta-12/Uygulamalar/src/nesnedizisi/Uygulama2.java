package nesnedizisi;

import java.util.Scanner;

import thisvesuperkullan�m�.Asker;

public class Uygulama2 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		Asker asker=new Asker(2000, "Havac�", "Ahmet Y�lmaz");
		�al��an []�al��anlar=new �al��an[3];
		�al��anlar[0]=new �al��an();
		�al��anlar[1]=new Memur();
		�al��anlar[2]=new ��retmen();
		//�al��anlar[0].�al��();
		�al��anlar[0].adsoyad="Ahmet Y�lmaz";
		�al��anlar[0].maa�=1500;
		�al��anlar[0].sicilno=1234;
		//-----------------------------------------------------
		�al��anlar[1].adsoyad="Mehmet Y�lmaz";
		�al��anlar[1].maa�=2500;
		�al��anlar[1].sicilno=1235;
		//-----------------------------------------------------
		�al��anlar[2].adsoyad="Sava� Y�lmaz";
		�al��anlar[2].maa�=3000;
		�al��anlar[2].sicilno=1236;
		//-----------------------------------------------------
		/*Memur yenimemur=(Memur) �al��anlar[1];//A�a�� �evrim
		��retmen yeni��retmen=(��retmen)�al��anlar[2];//A�a�� �evrim
		yenimemur.bilgiVer();
		yeni��retmen.bilgiVer();*/	
		/*for (int i = 0; i < �al��anlar.length; i++) {
			�al��anlar[i].�al��();
		}*/
		hepsini�al��t�r(�al��anlar);
	}

	private static void hepsini�al��t�r(�al��an[] �al��anlar) {
		for (int i = 0; i < �al��anlar.length; i++) {
			�al��anlar[i].�al��();
		}
		
	}
}
