import java.util.Scanner;


public class Uygulama7 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Yaþýnýzý Giriniz:");
		int yaþ=klavye.nextInt();
		try {
			yaþýDenetle(yaþ);
		} catch (Exception e) {
			System.out.println("Satýþ yapýlamaz.");
		}
	}
	private static void yaþýDenetle(int yaþ) throws Exception {
		if(yaþ<18)
			throw new Exception();
		else
			System.out.println("Satýþ yapýlabilir.");		
	}
}
