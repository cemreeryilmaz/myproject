import java.util.Scanner;
public class Uygulama2 {
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir sayý giriniz:");
		String sayý=klavye.next();
		//int sayý1=Integer.valueOf(sayý);//1.Yöntem
		int sayý1=Integer.parseInt(sayý);//2.Yöntem
		System.out.println("Sayýnýn iki katý:"+sayý1*2);
		klavye.close();
	}
}
