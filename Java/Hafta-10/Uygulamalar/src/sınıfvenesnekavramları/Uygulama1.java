package sýnýfvenesnekavramlarý;

import java.awt.Color;
import java.util.Scanner;

public class Uygulama1 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Birinci sayýyý giriniz:");
		double sayý1=klavye.nextDouble();
		System.out.println("Ýkinci sayýyý giriniz:");
		double sayý2=klavye.nextDouble();
		System.out.println("Toplama için[1],Çýkarma için[2],Bölme için[3],Çarpma için[4]");
		int tercih=klavye.nextInt();
		HesapMakinasý hesapmakinasý=new HesapMakinasý("Kare", 12, 20, Color.gray);
		if(tercih==1){
			System.out.println("Sonuç:"+hesapmakinasý.toplamaYap(sayý1, sayý2));
		}
		else if(tercih==2){
			System.out.println("Sonuç:"+hesapmakinasý.çýkarmaYap(sayý1, sayý2));
		}
		else if(tercih==3){
			System.out.println("Sonuç:"+hesapmakinasý.bölmeYap(sayý1, sayý2));
		}
		else if(tercih==4){
			System.out.println("Sonuç:"+hesapmakinasý.çarpmaYap(sayý1, sayý2));
		}
		else{
			System.out.println("Hatalý Giriþ....");
		}klavye.close();
	}

}
