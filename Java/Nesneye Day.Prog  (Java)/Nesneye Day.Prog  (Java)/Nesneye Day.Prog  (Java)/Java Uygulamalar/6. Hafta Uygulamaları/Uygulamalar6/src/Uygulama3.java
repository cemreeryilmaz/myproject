import java.util.Scanner;
public class Uygulama3 {
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ondal�kl� say� giriniz:");
		double say�=klavye.nextDouble();
		String s1=String.valueOf(say�);//1.Y�ntem
		System.out.println("1.Y�ntem:"+s1);
		String s2=Double.toString(say�);
		System.out.println("2.Y�ntem:"+s2);//2.Y�ntem
		klavye.close();
	}
}
