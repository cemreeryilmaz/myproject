package bittabanl�operat�rler;

import java.util.Scanner;

public class Uygulama3 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ba�lang�� de�erini giriniz:");
		int say�=klavye.nextInt();
		System.out.println("Sola do�ru ka� bit kayd�r�ls�n?:");
		System.out.println("��lem sonucu:"+(say�<<klavye.nextInt()));
		System.out.println("��lem sonu say� de�i�kenin i�eri�i:"+say�);
		System.out.println("Sa�a do�ru ka� bit kayd�r�ls�n?:");
		System.out.println("��lem sonucu:"+(say�>>klavye.nextInt()));
		klavye.close();
	}
}
