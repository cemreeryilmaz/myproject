import java.util.Scanner;
public class Uygulama2 {
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir say� giriniz:");
		String say�=klavye.next();
		//int say�1=Integer.valueOf(say�);//1.Y�ntem
		int say�1=Integer.parseInt(say�);//2.Y�ntem
		System.out.println("Say�n�n iki kat�:"+say�1*2);
		klavye.close();
	}
}
