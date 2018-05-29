package operatörler;

import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
	Scanner klavye=new Scanner(System.in);
	System.out.println("İlk sayıyı giriniz:");
	int sayı1=klavye.nextInt();
	System.out.println("İkinci sayıyı giriniz:");
	int sayı2=klavye.nextInt();
	System.out.println("İlk sayı ikinci sayıdan büyük mü?:"+(sayı1>sayı2));

	}

}
