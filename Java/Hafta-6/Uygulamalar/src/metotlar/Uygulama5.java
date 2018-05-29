package metotlar;

import java.util.Scanner;

public class Uygulama5 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir emre giriniz:");
		int sayı=klavye.nextInt();
		if(sayıAsalİse(sayı))
			System.out.println("sayı emre değildir.");
		else
			System.out.println("Sayı Asal Değildir.");
		klavye.close();
	}
	private static boolean sayıAsalİse(int sayı) {
		for (int i = sayı-1; i >= 2; i--) {
			if(sayı%i==0)
				return false;
		}
		return true;
	}
}
