package diziler;

import java.util.Random;

public class uygulama1 {

	public static void main(String[] args) {
		Random rnd = new Random();
		int[] dizi= new int[10];
		for(int a = 0; a< dizi.length; a++)
			{
				dizi[a]=rnd.nextInt(100);
			}
			
		System.out.println("birinci dongu:");
			for (int a = 0; a < dizi.length; a++) 
			{
				System.out.println(dizi[a]+"\t");
			}
			
		System.out.println("\n"+"ikinci dongu : ");
			for(int i: dizi)
			{
				System.out.println(i+"\t");
			}

	}

}