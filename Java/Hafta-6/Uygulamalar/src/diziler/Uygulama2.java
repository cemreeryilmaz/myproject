package diziler;

import java.util.Scanner;

public class Uygulama2 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Sat�r adedini giriniz:");
		int sat�radedi=klavye.nextInt();
		System.out.println("S�tun adedini giriniz:");
		int s�tunadedi=klavye.nextInt();
		System.out.println("Ba�lang�� de�erini giriniz:");
		int ba�lang��de�eri=klavye.nextInt();
		int[][]dizi=new int[sat�radedi][s�tunadedi];
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi[i].length; j++) {
				dizi[i][j]=ba�lang��de�eri;
				ba�lang��de�eri++;
			}
		}
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi[i].length; j++) {
				System.out.print(dizi[i][j]+"\t");
			}
			System.out.println();
		}
	}
}
