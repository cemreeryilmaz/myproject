import java.util.Scanner;


public class asalolupolmad�g� {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		@SuppressWarnings("resource")
		Scanner giris=new Scanner(System.in);
		System.out.println("bir say� giriniz : ");
		int sayi=giris.nextInt();
		int bolen=sayi-1;
		if(sayi>=2){
		while (sayi%bolen!=0) {
			bolen--;
			
		}
		if(bolen==1)
		{
			System.out.println("say� asald�r ");
		}
		else
		{
			System.out.println("say� asal de�ildir ");
			
		}
		}
		else
		{System.out.println("hatal� giris");
		
			
		}
	}

}
