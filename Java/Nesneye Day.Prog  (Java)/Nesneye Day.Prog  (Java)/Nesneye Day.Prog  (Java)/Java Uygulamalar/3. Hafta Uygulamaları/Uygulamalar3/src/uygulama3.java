import java.util.Scanner;


public class uygulama3 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Say� giriniz:");
		int say�=klavye.nextInt();
		if(say�==10)
		{
			System.out.println("E�it");
		}
		else if(say�<10)
		{
			System.out.println("K���k");
		}
		else{
			System.out.println("B�y�k");
		}

	}

}
