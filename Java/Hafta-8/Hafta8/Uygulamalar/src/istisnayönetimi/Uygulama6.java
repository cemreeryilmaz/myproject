package istisnay�netimi;

import java.util.Scanner;

public class Uygulama6 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("B�l�necek say�y� giriniz");
		int b�l�neceksay�=klavye.nextInt();
		System.out.println("B�len say�y� giriniz:");
		int b�lensay�=klavye.nextInt();
		try {
			System.out.println("B�l�m sonucu:"+b�l�neceksay�/b�lensay�);
		} catch (ArithmeticException e) {
			System.out.println("S�f�ra b�l�m tan�ms�zd�r.");
		}
	}
}
