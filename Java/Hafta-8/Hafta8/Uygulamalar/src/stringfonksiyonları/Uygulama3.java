package stringfonksiyonlar�;

import java.util.Scanner;

public class Uygulama3 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner (System.in);
		System.out.println("Bir kelime giriniz:");
		String kelime=klavye.nextLine();
		System.out.println("Ka��nc� karakterden ba�las�n?:");
		int ba�lang��=klavye.nextInt();
		System.out.println("Ka��nc� karakterde sonlans�n?:");
		int son=klavye.nextInt();
		System.out.println("�ekilen string:"+kelime.substring(ba�lang��-1, son));
		klavye.close();
	}
}
