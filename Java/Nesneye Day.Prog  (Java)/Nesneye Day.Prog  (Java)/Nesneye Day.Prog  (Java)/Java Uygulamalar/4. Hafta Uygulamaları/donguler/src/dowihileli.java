import java.util.Scanner;


public class dowihileli {

	
	public static void main(String[] args) {
		
		Scanner giris=new Scanner(System.in);
		System.out.println("bir sayý giriniz : ");
		int sayi=giris.nextInt();
		do{
			System.out.println("sayýnýn karesi "+Math.pow(sayi, 2));
			System.out.println("bir sayý giriniz : ");
	sayi=giris.nextInt();
		}while(sayi!=0);
		System.out.println("iþlem bitmiþtir.miseynt komleyt :D");
	}

}
