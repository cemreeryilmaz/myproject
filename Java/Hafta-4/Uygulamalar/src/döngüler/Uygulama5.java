package d�ng�ler;

import java.util.Scanner;
public class Uygulama5 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner (System.in);
		System.out.println("Bir say� giriniz.");
		int say�=klavye.nextInt();
		for (int i = say�; i >= 0; i--) {
			System.out.println(i);			
		}
	}
}
