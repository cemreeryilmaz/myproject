import java.util.Scanner;

public class Uygulama8 {
	
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir sayı giriniz:");
		int sayı=klavye.nextInt();
		geriyeSay(sayı);
	}
	private static void geriyeSay(int sayı) {
		if(sayı>=0){
		System.out.println(sayı);
		geriyeSay(sayı-1);
		}
		
	}

}
