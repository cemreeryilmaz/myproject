import java.util.InputMismatchException;
import java.util.Scanner;

public class Uygulama1 {
	
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir tamsay� giriniz:");
		try {
		int say�=klavye.nextInt();
		System.out.println("Girdi�iniz say�:"+say�);
		} catch (InputMismatchException e) {
			System.out.println(e.toString());
		}	
		klavye.close();
	}
}
