package metotlar;

import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir say� giriniz:");
		int say�=klavye.nextInt();
		if(say��ift�se(say�)){
			System.out.println("Say� �ifttir.");
		}else{
			System.out.println("Say� tektir.");
		}
		klavye.close();
	}
	private static boolean say��ift�se(int say�) {
		if(say�%2==0)
			return true;
		else
		return false;
	}
}
