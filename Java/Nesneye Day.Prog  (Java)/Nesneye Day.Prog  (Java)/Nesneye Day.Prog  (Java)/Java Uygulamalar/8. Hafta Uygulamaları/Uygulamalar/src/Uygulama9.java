import java.util.Scanner;


public class Uygulama9 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir say� giriniz:");
		int say�=klavye.nextInt();
		System.out.println("Say�n�n fakt�riyeli:"+fakt�riyelAl(say�));

	}
	private static int fakt�riyelAl(int say�) {
		if(say�>=2){
			say�*=fakt�riyelAl(say�-1);
		}
		return say�;
	}
}
