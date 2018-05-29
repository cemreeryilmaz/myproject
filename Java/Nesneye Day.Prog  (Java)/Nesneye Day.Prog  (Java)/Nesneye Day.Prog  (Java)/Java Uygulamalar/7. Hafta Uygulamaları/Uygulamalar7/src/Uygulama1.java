import java.util.InputMismatchException;
import java.util.Scanner;

public class Uygulama1 {
	
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir tamsayý giriniz:");
		try {
		int sayý=klavye.nextInt();
		System.out.println("Girdiðiniz sayý:"+sayý);
		} catch (InputMismatchException e) {
			System.out.println(e.toString());
		}	
		klavye.close();
	}
}
