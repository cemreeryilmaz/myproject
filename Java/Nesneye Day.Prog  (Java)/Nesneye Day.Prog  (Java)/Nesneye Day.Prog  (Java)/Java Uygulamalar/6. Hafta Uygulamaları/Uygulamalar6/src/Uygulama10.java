import java.util.Scanner;

public class Uygulama10 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("ad soyad giriniz:");
		String adsoyad=klavye.nextLine();
		String[]dizi=adsoyad.split(" ");
		System.out.println("Adýnýz:"+dizi[0]);
		System.out.println("Ýkinci adýnýz:"+dizi[1]);
		System.out.println("Soyadýnýz:"+dizi[2]);
	}
}
