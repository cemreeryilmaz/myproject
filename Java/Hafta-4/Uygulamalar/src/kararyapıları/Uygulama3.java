package kararyap�lar�;

import java.util.Scanner;

public class Uygulama3 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Klavyeden bir g�n giriniz.");
		String g�n=klavye.nextLine().toLowerCase();
		switch (g�n) {
		case "pazartesi":
			System.out.println("Birinci g�n");
			break;
		case "sal�":
			System.out.println("�kinci g�n");
			break;
		case "�ar�amba":
			System.out.println("���nc� g�n");
			break;
		case "per�embe":
			System.out.println("D�rd�nc� g�n");
			break;
		case "cuma":
			System.out.println("Be�inci g�n");
			break;
		case "cumartesi":
			System.out.println("Alt�nc� g�n");
			break;
		case "pazar":
			System.out.println("Yedinci g�n");
			break;
		default:
			System.out.println("Hatal� giri�.");
			break;
		}
		klavye.close();
	}
}
