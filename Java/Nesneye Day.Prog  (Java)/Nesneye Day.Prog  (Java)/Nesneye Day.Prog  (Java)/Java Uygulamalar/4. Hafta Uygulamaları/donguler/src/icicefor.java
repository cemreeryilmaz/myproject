import java.util.Scanner;


public class icicefor {

	
	public static void main(String[] args) {
		Scanner giris=new Scanner(System.in);
		System.out.println("sutunu giriniz : ");
		int sayi=giris.nextInt();
		System.out.println("satýrý : ");
		int t=giris.nextInt();
	
		for (int i = 0; i < t; i++) {
			for (int j = 0; j < sayi; j++) {
				System.out.print(((sayi*i)+(j+1))+" ");
			
			}
			System.out.println(" ");
		}

	}

}
