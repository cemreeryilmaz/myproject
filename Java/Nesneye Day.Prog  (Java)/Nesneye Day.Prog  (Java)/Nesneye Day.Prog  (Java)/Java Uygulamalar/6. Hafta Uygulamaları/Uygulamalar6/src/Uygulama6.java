import java.util.Scanner;

public class Uygulama6 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		String þifre="123asd";
		System.out.println("Þifreyi giriniz:");
		String girilen=klavye.next();
		if(þifre.compareTo(girilen)==0){
			System.out.println("Þifre Doðru");
		}
		else{
			System.out.println("Þifre Yanlýþ.");
		}
	}
}
