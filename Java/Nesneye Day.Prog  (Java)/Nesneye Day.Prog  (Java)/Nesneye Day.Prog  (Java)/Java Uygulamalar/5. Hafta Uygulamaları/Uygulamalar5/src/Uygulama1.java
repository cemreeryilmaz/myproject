import java.util.Scanner;


public class Uygulama1 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Kaç satýr?:");
		int satýrsayýsý=klavye.nextInt();
		int boþluksayýsý=0;
		int yýldýzsayýsý=satýrsayýsý*2-1;
		//kullanýcýnýn girdiði satýrsayýsýnýn iki katýnýn
		//bir eksiði yýldýz sayýsý olarak belirlendi.
		for (int i = 0; i < satýrsayýsý; i++) {//Bu döngü satýrda
			//ilerlememizi saðlýyor
			for (int j = 0; j < boþluksayýsý; j++) {
				//Bu döngü boþluk basmaya yarýyor...
				System.out.print(" ");
			}
			for (int j = 0; j < yýldýzsayýsý; j++) {
				//Bu döngü yýldýz basmaya yarýyor...
				System.out.print("*");
			}
			System.out.println();
			boþluksayýsý++;
			yýldýzsayýsý-=2;
		}

	}

}
