package d�ng�ler;

import java.util.Scanner;

public class Uygulama6 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir say� giriniz.");
		int say�=klavye.nextInt();
		for (int i = say�; i >1; i--) {
			say�=say�*(i-1);			
		}
		System.out.println("Sonu�:"+say�);
	}
}
