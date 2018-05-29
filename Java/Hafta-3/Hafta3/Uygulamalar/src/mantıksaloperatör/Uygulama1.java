package mantıksaloperatör;

import java.util.Scanner;

public class Uygulama1 {

	public static void main(String[] args) {
		
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir sayı giriniz:");
		int sayı=klavye.nextInt();
		System.out.println("Girilen değer 0 ile 100 veya 200 ile 300 arasında mı?:"+
		(((sayı>=0)&&(sayı<=100))||((sayı>=200)&&(sayı<=300))));
		klavye.close();
	}
}
