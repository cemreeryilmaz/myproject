package metotlar;

import java.util.Scanner;

public class Uygulama3 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Birinci say�y� giriniz:");
		int say�1=klavye.nextInt();
		System.out.println("�kinci say�y� giriniz:");
		int say�2=klavye.nextInt();
		�arp�mYap(say�1,say�2);
		int sonu�=�arp�mYap2(say�1,say�2);
		System.out.println("Sonu�:"+sonu�);
	}
	private static int �arp�mYap2(int say�1, int say�2) {
		return say�1*say�2;
	}
	public static  void �arp�mYap(int s1, int s2) {
		System.out.println("Sonu�:"+s1*s2);		
	}
}
