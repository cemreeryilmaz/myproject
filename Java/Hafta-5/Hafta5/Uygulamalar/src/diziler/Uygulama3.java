package diziler;

import java.util.Scanner;

public class Uygulama3 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		int []dizi=new int[7];
		for (int i = 0; i < dizi.length; i++) {//Diziye eleman yerle�tirme
			System.out.println(i+1+". say�y� giriniz:");
			dizi[i]=klavye.nextInt();
		}//S�ralama Ba�lang��
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi.length-1; j++) {
				if(dizi[j]<dizi[j+1]){//>k���kten b�y��e,< b�y�kten k����e
					int yedek=dizi[j];
					dizi[j]=dizi[j+1];
					dizi[j+1]=yedek;
				}
			}
		}//S�ralama Biti�
		//Konsolda g�sterme i�lemi.
		for (int i = 0; i < dizi.length; i++) {
			System.out.print(dizi[i]+"\t");
		}
		klavye.close();
	}
}