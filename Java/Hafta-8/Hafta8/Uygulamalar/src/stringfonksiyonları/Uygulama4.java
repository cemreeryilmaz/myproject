package stringfonksiyonlar�;

import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir tarih giriniz:");
		String tarih=klavye.nextLine();
		String []dizi=tarih.split("-");
		System.out.println("G�n:"+dizi[0]);
		System.out.println("Ay:"+dizi[1]);
		System.out.println("Y�l:"+dizi[2]);
		klavye.close();		
	}
}
