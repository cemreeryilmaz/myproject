import java.util.Scanner;
public class Uygulama11 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir cümle giriniz:");
		String cümle=klavye.nextLine();
		String yenicümle=cümle.replace(" ", "_");
		System.out.println("Yeni cümle:"+yenicümle);
	}
}
