package döngüler;

import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Karesini bulmak istediðini sayýyý giriniz,çýkmak için 0");
		int sayý=klavye.nextInt();
		/*while(sayý!=0){
			//int sonuç=sayý*sayý;
			int sonuç=(int) Math.pow(sayý, 2);
			System.out.println("Sayýnýn karesi:"+sonuç);
			System.out.println("Karesini bulmak istediðini sayýyý giriniz,çýkmak için 0");
			sayý=klavye.nextInt();
		}*/
		//Aralarýndaki fark; while önce mantýksal ifadeye bakýp sonra kodu iþler,
		//do while önce kodu iþleyip sonra mantýksal ifadeye bakar.
		//Programda do while ile döngü yapýldýðýnda ilk kez girilen sayý 0
		//olsa dahi hesaplamayý yapýp sonra mantýksal ifadeye baktýðý için 0 ýn da
		//karesini hesaplar, ikince kez giriþte 0 girildiðinde döngü sonlanýr.
		do {
			int sonuç=(int) Math.pow(sayý, 2);
			System.out.println("Sayýnýn karesi:"+sonuç);
			System.out.println("Karesini bulmak istediðini sayýyý giriniz,çýkmak için 0");
			sayý=klavye.nextInt();
		} while (sayý!=0);
	}
}
