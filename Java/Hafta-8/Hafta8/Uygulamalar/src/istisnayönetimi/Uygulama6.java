package istisnayönetimi;

import java.util.Scanner;

public class Uygulama6 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bölünecek sayýyý giriniz");
		int bölüneceksayý=klavye.nextInt();
		System.out.println("Bölen sayýyý giriniz:");
		int bölensayý=klavye.nextInt();
		try {
			System.out.println("Bölüm sonucu:"+bölüneceksayý/bölensayý);
		} catch (ArithmeticException e) {
			System.out.println("Sýfýra bölüm tanýmsýzdýr.");
		}
	}
}
