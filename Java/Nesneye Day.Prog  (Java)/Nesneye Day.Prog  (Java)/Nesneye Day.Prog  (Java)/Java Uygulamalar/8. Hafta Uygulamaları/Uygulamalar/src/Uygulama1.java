import java.util.Scanner;

public class Uygulama1 {
	
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir tamsay� giriniz:");
		int say�=klavye.nextInt();
		if(say�<10){
			k���kYaz();
		}else{
			k���kDe�ilYaz();
		}
	}
	private static void k���kDe�ilYaz() {
		System.out.println("Girilen say� 10'dan k���k de�ildir.");		
	}
	private static void k���kYaz() {
		System.out.println("Say� 10'dan k���kt�r");		
	}
}
