import java.util.Scanner;

public class Uygulama5 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir kelime giriniz:");
		String kelime=klavye.nextLine();
		System.out.println("Tersten yazılmış hali:"+tersCümle(kelime));
	}
	private static String tersCümle(String kelime) {
		String yenikelime ="";
		for (int i = kelime.length()-1; i >= 0; i--) {
			yenikelime+=kelime.charAt(i);
		}
		return yenikelime;
	}
}
