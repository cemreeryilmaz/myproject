package operatörler;

import java.util.Scanner;

public class Uygulama3 {

	public static void main(String[] args) {
	Scanner klavye=new Scanner(System.in);
	System.out.println("Sayýnýn baþlangýç deðerini giriniz:");
	int sayý=klavye.nextInt();
	System.out.println("Çarpýlacak sayýyý giriniz:");
	System.out.println("Sayýnýn son hali:"+(sayý*=klavye.nextInt()));
	System.out.println("Eklenecek sayýyý giriniz:");
	System.out.println("Sayýnýn son hali:"+(sayý+=klavye.nextInt()));
	System.out.println("Çýkarýlacak sayýyý giriniz:");
	System.out.println("Sayýnýn son hali:"+(sayý-=klavye.nextInt()));
	System.out.println("Bölünecek sayýyý giriniz:");
	System.out.println("Sayýnýn son hali:"+(sayý/=klavye.nextInt()));
	System.out.println("Mod alýnacak sayýyý giriniz:");
	System.out.println("Sayýnýn son hali:"+(sayý%=klavye.nextInt()));
	klavye.close();
	}
}
