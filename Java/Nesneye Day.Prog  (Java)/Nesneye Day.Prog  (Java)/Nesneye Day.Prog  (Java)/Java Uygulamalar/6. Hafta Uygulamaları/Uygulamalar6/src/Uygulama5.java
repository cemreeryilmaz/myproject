import java.util.Scanner;

public class Uygulama5 {
	
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ad�n�z� giriniz:");
		String ad=klavye.next();
		System.out.println("Soyad�n�z� giriniz:");
		String soyad=klavye.next();
		System.out.println("Ad�n�z-Soyad�n�z:"+ad.concat(" "+soyad));
		System.out.println("Ad�n�z�n ilk harfi:"+ad.charAt(0));
		System.out.println("Soyad�n�z�n ilk harfi:"+soyad.charAt(0));

	}

}
