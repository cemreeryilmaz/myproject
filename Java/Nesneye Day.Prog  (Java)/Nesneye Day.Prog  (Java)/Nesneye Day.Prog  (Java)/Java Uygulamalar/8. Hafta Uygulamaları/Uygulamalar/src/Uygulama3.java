import java.util.Scanner;
public class Uygulama3 {
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("K�sa kenar� giriniz:");
		int k�sakenar=klavye.nextInt();
		System.out.println("Uzun kenar� giriniz:");
		int uzunkenar=klavye.nextInt();
		int alan=alanHesapla(k�sakenar,uzunkenar);
		int �evre=�evreHesapla(k�sakenar,uzunkenar);
		System.out.println("Alan�:"+alan);
		System.out.println("�evresi:"+�evre);
	}
	private static int �evreHesapla(int k�sakenar, int uzunkenar) {		
		return 2*(uzunkenar+k�sakenar);
	}
	private static int alanHesapla(int k�sakenar, int uzunkenar) {		
		return k�sakenar*uzunkenar;
	}
}
