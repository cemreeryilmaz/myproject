import java.util.Scanner;

public class Uygulama1 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir sayý giriniz:");
		int sayý=klavye.nextInt();
		System.out.println("1.yöntem:"+String.valueOf(sayý));
		System.out.println("2.Yöntem:"+sayý+"");
		System.out.println("3.yöntem:"+Integer.toString(sayý));
		klavye.close();

	}

}
