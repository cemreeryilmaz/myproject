import java.util.Scanner;

public class Uygulama5 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir kelime giriniz:");
		String kelime=klavye.nextLine();
		System.out.println("Tersten yaz�lm�� hali:"+tersC�mle(kelime));
	}
	private static String tersC�mle(String kelime) {
		String yenikelime ="";
		for (int i = kelime.length()-1; i >= 0; i--) {
			yenikelime+=kelime.charAt(i);
		}
		return yenikelime;
	}
}
