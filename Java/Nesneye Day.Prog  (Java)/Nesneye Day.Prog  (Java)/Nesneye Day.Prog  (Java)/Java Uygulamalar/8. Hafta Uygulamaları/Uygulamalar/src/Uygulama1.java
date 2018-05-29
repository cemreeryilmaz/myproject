import java.util.Scanner;

public class Uygulama1 {
	
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir tamsayý giriniz:");
		int sayý=klavye.nextInt();
		if(sayý<10){
			küçükYaz();
		}else{
			küçükDeðilYaz();
		}
	}
	private static void küçükDeðilYaz() {
		System.out.println("Girilen sayý 10'dan küçük deðildir.");		
	}
	private static void küçükYaz() {
		System.out.println("Sayý 10'dan küçüktür");		
	}
}
