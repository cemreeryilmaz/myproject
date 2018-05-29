import java.util.Scanner;

public class Uygulama2 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir tamsayý giriniz:");
		int sayý=klavye.nextInt();
		if(küçükMü(sayý)){
			System.out.println("Sayý 10'dan küçüktür.");
		}else{
			System.out.println("Sayý 10'dan küçük deðildir");
		}
	}
	private static boolean küçükMü(int s) {
		if(s<10){
			return true;
		}else{
		return false;
		}
	}
}
