import java.util.Scanner;


public class Uygulama1 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ka� sat�r?:");
		int sat�rsay�s�=klavye.nextInt();
		int bo�luksay�s�=0;
		int y�ld�zsay�s�=sat�rsay�s�*2-1;
		//kullan�c�n�n girdi�i sat�rsay�s�n�n iki kat�n�n
		//bir eksi�i y�ld�z say�s� olarak belirlendi.
		for (int i = 0; i < sat�rsay�s�; i++) {//Bu d�ng� sat�rda
			//ilerlememizi sa�l�yor
			for (int j = 0; j < bo�luksay�s�; j++) {
				//Bu d�ng� bo�luk basmaya yar�yor...
				System.out.print(" ");
			}
			for (int j = 0; j < y�ld�zsay�s�; j++) {
				//Bu d�ng� y�ld�z basmaya yar�yor...
				System.out.print("*");
			}
			System.out.println();
			bo�luksay�s�++;
			y�ld�zsay�s�-=2;
		}

	}

}
