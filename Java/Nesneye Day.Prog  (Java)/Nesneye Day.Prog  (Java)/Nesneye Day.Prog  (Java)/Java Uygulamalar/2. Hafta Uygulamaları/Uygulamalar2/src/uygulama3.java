import java.util.Scanner;

public class uygulama3 {
	
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("1.sayıyı giriniz:");
		int sayı1=klavye.nextInt();
		System.out.println("2.sayıyı giriniz:");
		int sayı2=klavye.nextInt();
		System.out.println("Büyük olan sayı:"+(sayı1>sayı2?sayı1:sayı2));
		System.out.println("Küçük olan sayı:"+(sayı1<sayı2?sayı1:sayı2));

	}

}
