package bittabanl�operat�rler;

import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Birinci say�y� giriniz:");
		byte say�1=klavye.nextByte();
		System.out.println("�kinci say�y� giriniz:");
		byte say�2=klavye.nextByte();
		String sonu�=(say�1==say�2)?"Birbirine e�it":"E�it de�il";
		System.out.println("Kar��la�t�rma sonucu:"+sonu�);
		klavye.close();
	}
}
