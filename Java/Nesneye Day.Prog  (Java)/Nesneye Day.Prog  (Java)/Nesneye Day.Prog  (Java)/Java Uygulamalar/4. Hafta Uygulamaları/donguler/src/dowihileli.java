import java.util.Scanner;


public class dowihileli {

	
	public static void main(String[] args) {
		
		Scanner giris=new Scanner(System.in);
		System.out.println("bir say� giriniz : ");
		int sayi=giris.nextInt();
		do{
			System.out.println("say�n�n karesi "+Math.pow(sayi, 2));
			System.out.println("bir say� giriniz : ");
	sayi=giris.nextInt();
		}while(sayi!=0);
		System.out.println("i�lem bitmi�tir.miseynt komleyt :D");
	}

}
