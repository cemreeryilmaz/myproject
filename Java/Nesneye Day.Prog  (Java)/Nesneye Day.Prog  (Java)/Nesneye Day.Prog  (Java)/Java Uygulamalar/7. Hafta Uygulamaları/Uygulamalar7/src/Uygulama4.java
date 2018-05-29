import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ondalýklý sayý giriniz:");
		String sayý=klavye.nextLine();
		try {
			System.out.println("Sayý:"+Double.valueOf(sayý));
		} catch (NumberFormatException e) {
			sayý=sayý.replace(',', '.');
			System.out.println("Sayý:"+Double.valueOf(sayý));
		}
		
	}
}
