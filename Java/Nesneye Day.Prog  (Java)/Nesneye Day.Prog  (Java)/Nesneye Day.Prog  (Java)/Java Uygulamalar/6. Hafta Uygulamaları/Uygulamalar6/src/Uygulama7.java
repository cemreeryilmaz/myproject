import java.util.Scanner;

public class Uygulama7 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir kelime giriniz:");
		String kelime=klavye.next();
		System.out.println("Kelimenin uzunluðu:"+kelime.length());
		klavye.close();

	}

}
