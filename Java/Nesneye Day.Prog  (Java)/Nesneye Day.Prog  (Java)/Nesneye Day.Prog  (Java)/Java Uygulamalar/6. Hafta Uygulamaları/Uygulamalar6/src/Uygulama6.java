import java.util.Scanner;

public class Uygulama6 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		String �ifre="123asd";
		System.out.println("�ifreyi giriniz:");
		String girilen=klavye.next();
		if(�ifre.compareTo(girilen)==0){
			System.out.println("�ifre Do�ru");
		}
		else{
			System.out.println("�ifre Yanl��.");
		}
	}
}
