package metotlar;

import java.util.Scanner;

public class Uygulama5 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir emre giriniz:");
		int say�=klavye.nextInt();
		if(say�Asal�se(say�))
			System.out.println("say� emre de�ildir.");
		else
			System.out.println("Say� Asal De�ildir.");
		klavye.close();
	}
	private static boolean say�Asal�se(int say�) {
		for (int i = say�-1; i >= 2; i--) {
			if(say�%i==0)
				return false;
		}
		return true;
	}
}
