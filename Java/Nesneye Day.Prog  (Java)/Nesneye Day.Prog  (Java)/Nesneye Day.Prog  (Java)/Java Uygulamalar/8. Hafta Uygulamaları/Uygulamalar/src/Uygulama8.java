import java.util.Scanner;

public class Uygulama8 {
	
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir say� giriniz:");
		int say�=klavye.nextInt();
		geriyeSay(say�);
	}
	private static void geriyeSay(int say�) {
		if(say�>=0){
		System.out.println(say�);
		geriyeSay(say�-1);
		}
		
	}

}
