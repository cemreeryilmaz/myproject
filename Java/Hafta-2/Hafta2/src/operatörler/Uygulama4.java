package operat�rler;

import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
	Scanner klavye=new Scanner(System.in);
	System.out.println("�lk say�y� giriniz:");
	int say�1=klavye.nextInt();
	System.out.println("�kinci say�y� giriniz:");
	int say�2=klavye.nextInt();
	System.out.println("�lk say� ikinci say�dan b�y�k m�?:"+(say�1>say�2));

	}

}
