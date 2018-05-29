import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ondalýklý sayý giriniz:");
		String sayý=klavye.next();
		System.out.println("1.Yöntem:"+Double.valueOf(sayý));
		System.out.println("2.Yöntem:"+Float.parseFloat(sayý));
		klavye.close();

	}

}
