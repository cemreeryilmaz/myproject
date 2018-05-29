import java.util.Scanner;


public class forlu {

	/**
	 * @param args
	 */

	public static void main(String[] args) {

		Scanner giris=new Scanner(System.in);
		System.out.println("bir sayý giriniz : ");
		int sayi=giris.nextInt();
	
		for (int bölen=sayi-1; bölen >= 2; bölen--)
		{
			
			if(sayi%bölen==0){
				System.out.println("sayý asal deðildi");
				
				return;
			}
		
		}
		


	
		System.out.println("sayý asaldýr");

	}
}
