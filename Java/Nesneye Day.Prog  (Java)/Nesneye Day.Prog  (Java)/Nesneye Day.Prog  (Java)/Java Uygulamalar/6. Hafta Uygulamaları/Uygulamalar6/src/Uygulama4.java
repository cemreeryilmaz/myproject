import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ondal�kl� say� giriniz:");
		String say�=klavye.next();
		System.out.println("1.Y�ntem:"+Double.valueOf(say�));
		System.out.println("2.Y�ntem:"+Float.parseFloat(say�));
		klavye.close();

	}

}
