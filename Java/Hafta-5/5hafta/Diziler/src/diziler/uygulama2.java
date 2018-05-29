package diziler;

import java.util.Scanner;

public class uygulama2 {

	public static void main(String[] args) {
		Scanner klavye = new Scanner(System.in);
		System.out.println("kac tane isim girilecek : ");
		int elemansayisi = klavye.nextInt();
		String[] isimler = new String[elemansayisi];
		for (int i = 0; i < isimler.length; i++) 
		{
			System.out.println(i+1+".nci isimi giriniz : ");
			isimler[i]=klavye.nextLine();
		}
		System.out.println("birinci dongu : ");
		for (String adlar : isimler)
		{
			System.out.println(adlar);
		}
		System.out.println("\nikinci dongu : ");
		for (int i = 0; i < isimler.length; i++) 
		{
			System.out.println(i+1+".nci isim : "+isimler);
		}
		klavye.close();
	}

}
