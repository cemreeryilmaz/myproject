package mant�ksaloperat�r;

import java.util.Scanner;

public class Uygulama1 {

	public static void main(String[] args) {
		
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir say� giriniz:");
		int say�=klavye.nextInt();
		System.out.println("Girilen de�er 0 ile 100 veya 200 ile 300 aras�nda m�?:"+
		(((say�>=0)&&(say�<=100))||((say�>=200)&&(say�<=300))));
		klavye.close();
	}
}
