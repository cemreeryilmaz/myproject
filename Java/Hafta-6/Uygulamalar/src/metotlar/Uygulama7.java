package metotlar;

import java.util.Scanner;

public class Uygulama7 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir say� giriniz:");
		int say�=klavye.nextInt();
		int denememiktar�=0;
		say�y�Bul(say�,denememiktar�);
	}

	private static void say�y�Bul(int say�, int denememiktar�) {
		int rasgelesay�=(int) (Math.random()*100);
		if(rasgelesay�!=say�){
			denememiktar�++;
			say�y�Bul(say�,denememiktar�);
		}
		else
			System.out.println("Aranan say� bulundu,deneme miktar�:"+denememiktar�);			
	}

}