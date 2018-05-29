import java.util.Scanner;

public class Uygulama5 {
	
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Adýnýzý giriniz:");
		String ad=klavye.next();
		System.out.println("Soyadýnýzý giriniz:");
		String soyad=klavye.next();
		System.out.println("Adýnýz-Soyadýnýz:"+ad.concat(" "+soyad));
		System.out.println("Adýnýzýn ilk harfi:"+ad.charAt(0));
		System.out.println("Soyadýnýzýn ilk harfi:"+soyad.charAt(0));

	}

}
