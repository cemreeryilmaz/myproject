import java.util.Scanner;


public class Uygulama7 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ya��n�z� Giriniz:");
		int ya�=klavye.nextInt();
		try {
			ya��Denetle(ya�);
		} catch (Exception e) {
			System.out.println("Sat�� yap�lamaz.");
		}
	}
	private static void ya��Denetle(int ya�) throws Exception {
		if(ya�<18)
			throw new Exception();
		else
			System.out.println("Sat�� yap�labilir.");		
	}
}
