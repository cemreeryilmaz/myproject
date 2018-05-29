import java.util.Scanner;
public class Uygulama3 {
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Ondalýklý sayý giriniz:");
		double sayý=klavye.nextDouble();
		String s1=String.valueOf(sayý);//1.Yöntem
		System.out.println("1.Yöntem:"+s1);
		String s2=Double.toString(sayý);
		System.out.println("2.Yöntem:"+s2);//2.Yöntem
		klavye.close();
	}
}
