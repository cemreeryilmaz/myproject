package metotlar;

import java.util.Scanner;

public class Uygulama3 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Birinci sayýyý giriniz:");
		int sayý1=klavye.nextInt();
		System.out.println("Ýkinci sayýyý giriniz:");
		int sayý2=klavye.nextInt();
		çarpýmYap(sayý1,sayý2);
		int sonuç=çarpýmYap2(sayý1,sayý2);
		System.out.println("Sonuç:"+sonuç);
	}
	private static int çarpýmYap2(int sayý1, int sayý2) {
		return sayý1*sayý2;
	}
	public static  void çarpýmYap(int s1, int s2) {
		System.out.println("Sonuç:"+s1*s2);		
	}
}
