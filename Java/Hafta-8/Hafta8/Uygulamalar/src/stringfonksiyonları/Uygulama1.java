package stringfonksiyonlar�;

import java.util.Scanner;

public class Uygulama1 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("�lk stringi giriniz:");
		String ilkstring=klavye.nextLine();
		System.out.println("�kinci stringi giriniz:");
		String ikincistring=klavye.nextLine();
		/*if(ilkstring.compareToIgnoreCase(ikincistring)==0){
			System.out.println("Stringler birbirine e�it.");
		}*/
		if(ilkstring.equalsIgnoreCase(ikincistring)){
			System.out.println("Stringler birbirine e�it.");
		}
		else if(ilkstring.compareToIgnoreCase(ikincistring)<0){
			System.out.println("�lk string alfabetik olarak �ncedir.");
		}
		else{
			System.out.println("�kinci string alfabetik olarak �ncedir.");
		}
		klavye.close();
	}
}
