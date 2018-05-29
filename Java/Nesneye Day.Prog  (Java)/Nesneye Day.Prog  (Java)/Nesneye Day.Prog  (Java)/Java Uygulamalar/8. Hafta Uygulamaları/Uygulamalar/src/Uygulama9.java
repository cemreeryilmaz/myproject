import java.util.Scanner;


public class Uygulama9 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir sayı giriniz:");
		int sayı=klavye.nextInt();
		System.out.println("Sayının faktöriyeli:"+faktöriyelAl(sayı));

	}
	private static int faktöriyelAl(int sayı) {
		if(sayı>=2){
			sayı*=faktöriyelAl(sayı-1);
		}
		return sayı;
	}
}
