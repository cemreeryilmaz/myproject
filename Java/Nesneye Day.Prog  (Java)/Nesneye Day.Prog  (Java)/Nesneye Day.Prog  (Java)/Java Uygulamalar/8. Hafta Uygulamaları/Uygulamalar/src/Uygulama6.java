import java.util.Scanner;

public class Uygulama6 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir kelime giriniz:");
		String kelime=klavye.nextLine();
		System.out.println("Kaçýncý harften baþlasýn?:");
		int baþlangýç=klavye.nextInt();
		System.out.println("Kaçýncý harfte bitsin?:");
		int bitiþ=klavye.nextInt();
		System.out.println("Yeni kelime:"+araKelimeAl(kelime,baþlangýç,bitiþ));
	}
	private static String araKelimeAl(String kelime, int baþlangýç, int bitiþ){		
		return kelime.substring(baþlangýç-1, bitiþ);
	}

}
