import java.util.Scanner;


public class uygulama3 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Sayý giriniz:");
		int sayý=klavye.nextInt();
		if(sayý==10)
		{
			System.out.println("Eþit");
		}
		else if(sayý<10)
		{
			System.out.println("Küçük");
		}
		else{
			System.out.println("Büyük");
		}

	}

}
