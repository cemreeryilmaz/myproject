import java.util.Scanner;

public class Uygulama1 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir say� giriniz:");
		int say�=klavye.nextInt();
		System.out.println("1.y�ntem:"+String.valueOf(say�));
		System.out.println("2.Y�ntem:"+say�+"");
		System.out.println("3.y�ntem:"+Integer.toString(say�));
		klavye.close();

	}

}
