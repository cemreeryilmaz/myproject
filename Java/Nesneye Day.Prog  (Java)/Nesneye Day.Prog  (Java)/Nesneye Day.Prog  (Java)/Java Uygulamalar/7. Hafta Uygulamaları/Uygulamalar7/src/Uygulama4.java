import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ondal�kl� say� giriniz:");
		String say�=klavye.nextLine();
		try {
			System.out.println("Say�:"+Double.valueOf(say�));
		} catch (NumberFormatException e) {
			say�=say�.replace(',', '.');
			System.out.println("Say�:"+Double.valueOf(say�));
		}
		
	}
}
