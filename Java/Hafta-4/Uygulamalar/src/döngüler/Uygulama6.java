package döngüler;

import java.util.Scanner;

public class Uygulama6 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir sayı giriniz.");
		int sayı=klavye.nextInt();
		for (int i = sayı; i >1; i--) {
			sayı=sayı*(i-1);			
		}
		System.out.println("Sonuç:"+sayı);
	}
}
