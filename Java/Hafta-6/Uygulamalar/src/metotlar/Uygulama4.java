package metotlar;

import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir sayı giriniz:");
		int sayı=klavye.nextInt();
		if(sayıÇiftİse(sayı)){
			System.out.println("Sayı Çifttir.");
		}else{
			System.out.println("Sayı tektir.");
		}
		klavye.close();
	}
	private static boolean sayıÇiftİse(int sayı) {
		if(sayı%2==0)
			return true;
		else
		return false;
	}
}
