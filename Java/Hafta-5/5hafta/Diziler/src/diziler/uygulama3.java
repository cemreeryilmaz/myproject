package diziler;

import java.util.Scanner;

public class uygulama3 {

	public static void main(String[] args) {
		Scanner klavye = new Scanner(System.in);
		int[]dizi=new int[7];
		//eleman yerlestirme
		for (int i = 0; i < dizi.length; i++) 
		{
			System.out.println(i+1+".nci sayiyi gir : ");
			dizi[i] =klavye.nextInt();
		}
		//siralama
		for (int i = 0; i < dizi.length; i++) 
		{
			for (int j = 0; j < dizi.length; j++) 
			{
				if (dizi[j]>dizi[j+1]) 
				{
					int yedek = dizi[j];
					dizi[i]=dizi[j+1];
					dizi[j+1]=yedek;
				}
			}
		}
		//siralama bitis
		//konsola yazdir
		for (int i = 0; i < dizi.length; i++) 
		{
			System.out.println(dizi[i]+"\t");
		}
		klavye.close();
	}
}
