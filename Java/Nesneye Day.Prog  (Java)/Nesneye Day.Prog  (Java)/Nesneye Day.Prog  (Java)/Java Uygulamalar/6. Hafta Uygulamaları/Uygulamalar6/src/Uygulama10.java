import java.util.Scanner;

public class Uygulama10 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("ad soyad giriniz:");
		String adsoyad=klavye.nextLine();
		String[]dizi=adsoyad.split(" ");
		System.out.println("Ad�n�z:"+dizi[0]);
		System.out.println("�kinci ad�n�z:"+dizi[1]);
		System.out.println("Soyad�n�z:"+dizi[2]);
	}
}
