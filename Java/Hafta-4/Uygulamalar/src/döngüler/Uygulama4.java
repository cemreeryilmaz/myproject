package d�ng�ler;

import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Karesini bulmak istedi�ini say�y� giriniz,��kmak i�in 0");
		int say�=klavye.nextInt();
		/*while(say�!=0){
			//int sonu�=say�*say�;
			int sonu�=(int) Math.pow(say�, 2);
			System.out.println("Say�n�n karesi:"+sonu�);
			System.out.println("Karesini bulmak istedi�ini say�y� giriniz,��kmak i�in 0");
			say�=klavye.nextInt();
		}*/
		//Aralar�ndaki fark; while �nce mant�ksal ifadeye bak�p sonra kodu i�ler,
		//do while �nce kodu i�leyip sonra mant�ksal ifadeye bakar.
		//Programda do while ile d�ng� yap�ld���nda ilk kez girilen say� 0
		//olsa dahi hesaplamay� yap�p sonra mant�ksal ifadeye bakt��� i�in 0 �n da
		//karesini hesaplar, ikince kez giri�te 0 girildi�inde d�ng� sonlan�r.
		do {
			int sonu�=(int) Math.pow(say�, 2);
			System.out.println("Say�n�n karesi:"+sonu�);
			System.out.println("Karesini bulmak istedi�ini say�y� giriniz,��kmak i�in 0");
			say�=klavye.nextInt();
		} while (say�!=0);
	}
}
