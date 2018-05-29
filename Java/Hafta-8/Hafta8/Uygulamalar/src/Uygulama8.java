import java.util.Scanner;


public class Uygulama8 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Yaþýnýzý giriniz:");
		/*String yaþ=klavye.nextLine();
		int yaþ2;*/
		try {
			int yaþ=klavye.nextInt();
			System.out.println(yaþ);
		} catch (NumberFormatException|NullPointerException |ArithmeticException e ) {
			System.out.println("Klavyeden giriþ hatasý.");
		}
		klavye.close();
	}
}
