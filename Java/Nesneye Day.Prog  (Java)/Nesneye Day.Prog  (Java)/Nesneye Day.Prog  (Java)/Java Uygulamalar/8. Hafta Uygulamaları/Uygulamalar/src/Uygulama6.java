import java.util.Scanner;

public class Uygulama6 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir kelime giriniz:");
		String kelime=klavye.nextLine();
		System.out.println("Ka��nc� harften ba�las�n?:");
		int ba�lang��=klavye.nextInt();
		System.out.println("Ka��nc� harfte bitsin?:");
		int biti�=klavye.nextInt();
		System.out.println("Yeni kelime:"+araKelimeAl(kelime,ba�lang��,biti�));
	}
	private static String araKelimeAl(String kelime, int ba�lang��, int biti�){		
		return kelime.substring(ba�lang��-1, biti�);
	}

}
