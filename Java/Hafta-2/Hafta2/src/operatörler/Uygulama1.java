package operat�rler;

import java.util.Scanner;

public class Uygulama1 {

	public static void main(String[] args) {
		
		Scanner klavye=new Scanner(System.in);
		System.out.println("�lk say�y� giriniz:");
		int say�1=klavye.nextInt();
		System.out.println("�kinci say�y� giriniz:");
		int say�2=klavye.nextInt();
		//int sonu�=say�1*say�2;
		System.out.println("�ki say�n�n �arp�m�:"+say�1*say�2);
		System.out.println("�ki say�n�n toplam�:"+(say�1+say�2));
		System.out.println("�ki say�n�n fark�:"+(say�1-say�2));
		System.out.println("�ki say�n�n b�l�m�:"+say�1/say�2);
		System.out.println("�ki say�n�n b�l�m�nden kalan:"+say�1%say�2);
	}}
