import java.util.Scanner;


public class forlu {

	/**
	 * @param args
	 */

	public static void main(String[] args) {

		Scanner giris=new Scanner(System.in);
		System.out.println("bir say� giriniz : ");
		int sayi=giris.nextInt();
	
		for (int b�len=sayi-1; b�len >= 2; b�len--)
		{
			
			if(sayi%b�len==0){
				System.out.println("say� asal de�ildi");
				
				return;
			}
		
		}
		


	
		System.out.println("say� asald�r");

	}
}
