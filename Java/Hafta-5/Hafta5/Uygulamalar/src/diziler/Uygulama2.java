package diziler;

import java.util.Scanner;

public class Uygulama2 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ka� tane isim girmek istiyorsunuz?:");
		int elemansay�s�=klavye.nextInt();
		String[]isimler=new String[elemansay�s�];
		for (int i = 0; i < isimler.length; i++) {
			System.out.println(i+1+".nci ismi giriniz:");
			isimler[i]=klavye.next();
		}
		/*for (String adlar : isimler) {
			System.out.println(adlar);
		}*/
		for (int i = 0; i < isimler.length; i++) {
			System.out.println(i+1+".nci isim:"+isimler[i]);
		}
	}
}