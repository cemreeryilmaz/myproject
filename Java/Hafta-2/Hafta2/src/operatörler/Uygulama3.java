package operat�rler;

import java.util.Scanner;

public class Uygulama3 {

	public static void main(String[] args) {
	Scanner klavye=new Scanner(System.in);
	System.out.println("Say�n�n ba�lang�� de�erini giriniz:");
	int say�=klavye.nextInt();
	System.out.println("�arp�lacak say�y� giriniz:");
	System.out.println("Say�n�n son hali:"+(say�*=klavye.nextInt()));
	System.out.println("Eklenecek say�y� giriniz:");
	System.out.println("Say�n�n son hali:"+(say�+=klavye.nextInt()));
	System.out.println("��kar�lacak say�y� giriniz:");
	System.out.println("Say�n�n son hali:"+(say�-=klavye.nextInt()));
	System.out.println("B�l�necek say�y� giriniz:");
	System.out.println("Say�n�n son hali:"+(say�/=klavye.nextInt()));
	System.out.println("Mod al�nacak say�y� giriniz:");
	System.out.println("Say�n�n son hali:"+(say�%=klavye.nextInt()));
	klavye.close();
	}
}
