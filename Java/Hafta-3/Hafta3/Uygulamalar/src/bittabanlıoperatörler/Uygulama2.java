package bittabanl�operat�rler;

import java.util.Scanner;

public class Uygulama2 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Birinci say�y� giriniz:");
		byte say�1=klavye.nextByte();
		System.out.println("�kinci say�y� giriniz:");
		byte say�2=klavye.nextByte();
		System.out.println("�ki say�n�n AND i�lemi sonucu:"+(byte) (say�1&say�2));
		System.out.println("�ki say�n�n OR i�lemi sonucu:"+(byte) (say�1|say�2));
		System.out.println("�ki say�n�n XOR i�lemi sonucu:"+(byte) (say�1^say�2));
		System.out.println("Birinci say�n�n tersi:"+~say�1);
		System.out.println("�kinci say�n�n tersi:"+~say�2);
		klavye.close();
	}
}
