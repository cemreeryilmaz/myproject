import java.util.Scanner;


public class Uygulama8 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ya��n�z� giriniz:");
		/*String ya�=klavye.nextLine();
		int ya�2;*/
		try {
			int ya�=klavye.nextInt();
			System.out.println(ya�);
		} catch (NumberFormatException|NullPointerException |ArithmeticException e ) {
			System.out.println("Klavyeden giri� hatas�.");
		}
		klavye.close();
	}
}
