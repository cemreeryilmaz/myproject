import java.util.Scanner;

public class Uygulama9 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ad soyad giriniz:");
		String adsoyad=klavye.nextLine();
		String ad=adsoyad.substring(0, adsoyad.indexOf(" "));
		String soyad=adsoyad.substring(adsoyad.indexOf(" ")+1, adsoyad.length());
		System.out.println("Adýnýz:"+ad);
		System.out.println("Soyadýnýz:"+soyad);

	}

}
