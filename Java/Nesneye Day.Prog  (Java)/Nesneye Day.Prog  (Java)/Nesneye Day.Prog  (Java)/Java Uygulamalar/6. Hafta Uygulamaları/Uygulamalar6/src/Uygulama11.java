import java.util.Scanner;
public class Uygulama11 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir c�mle giriniz:");
		String c�mle=klavye.nextLine();
		String yenic�mle=c�mle.replace(" ", "_");
		System.out.println("Yeni c�mle:"+yenic�mle);
	}
}
