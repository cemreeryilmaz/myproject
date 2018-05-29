import java.util.Scanner;
public class Uygulama3 {
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Kýsa kenarý giriniz:");
		int kýsakenar=klavye.nextInt();
		System.out.println("Uzun kenarý giriniz:");
		int uzunkenar=klavye.nextInt();
		int alan=alanHesapla(kýsakenar,uzunkenar);
		int çevre=çevreHesapla(kýsakenar,uzunkenar);
		System.out.println("Alaný:"+alan);
		System.out.println("Çevresi:"+çevre);
	}
	private static int çevreHesapla(int kýsakenar, int uzunkenar) {		
		return 2*(uzunkenar+kýsakenar);
	}
	private static int alanHesapla(int kýsakenar, int uzunkenar) {		
		return kýsakenar*uzunkenar;
	}
}
