import java.util.Scanner;

public class Uygulama2 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir tamsay� giriniz:");
		int say�=klavye.nextInt();
		if(k���kM�(say�)){
			System.out.println("Say� 10'dan k���kt�r.");
		}else{
			System.out.println("Say� 10'dan k���k de�ildir");
		}
	}
	private static boolean k���kM�(int s) {
		if(s<10){
			return true;
		}else{
		return false;
		}
	}
}
