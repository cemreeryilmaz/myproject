package kararyapýlarý;

import java.util.Scanner;

public class Uygulama3 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Klavyeden bir gün giriniz.");
		String gün=klavye.nextLine().toLowerCase();
		switch (gün) {
		case "pazartesi":
			System.out.println("Birinci gün");
			break;
		case "salý":
			System.out.println("Ýkinci gün");
			break;
		case "çarþamba":
			System.out.println("Üçüncü gün");
			break;
		case "perþembe":
			System.out.println("Dördüncü gün");
			break;
		case "cuma":
			System.out.println("Beþinci gün");
			break;
		case "cumartesi":
			System.out.println("Altýncý gün");
			break;
		case "pazar":
			System.out.println("Yedinci gün");
			break;
		default:
			System.out.println("Hatalý giriþ.");
			break;
		}
		klavye.close();
	}
}
