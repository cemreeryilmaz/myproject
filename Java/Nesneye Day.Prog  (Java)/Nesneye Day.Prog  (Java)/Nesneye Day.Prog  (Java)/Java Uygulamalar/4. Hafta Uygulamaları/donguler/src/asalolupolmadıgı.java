import java.util.Scanner;


public class asalolupolmadýgý {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		@SuppressWarnings("resource")
		Scanner giris=new Scanner(System.in);
		System.out.println("bir sayý giriniz : ");
		int sayi=giris.nextInt();
		int bolen=sayi-1;
		if(sayi>=2){
		while (sayi%bolen!=0) {
			bolen--;
			
		}
		if(bolen==1)
		{
			System.out.println("sayý asaldýr ");
		}
		else
		{
			System.out.println("sayý asal deðildir ");
			
		}
		}
		else
		{System.out.println("hatalý giris");
		
			
		}
	}

}
