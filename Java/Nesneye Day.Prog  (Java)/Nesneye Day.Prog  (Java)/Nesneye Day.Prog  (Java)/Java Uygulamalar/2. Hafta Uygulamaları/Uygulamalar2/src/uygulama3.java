import java.util.Scanner;

public class uygulama3 {
	
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("1.say�y� giriniz:");
		int say�1=klavye.nextInt();
		System.out.println("2.say�y� giriniz:");
		int say�2=klavye.nextInt();
		System.out.println("B�y�k olan say�:"+(say�1>say�2?say�1:say�2));
		System.out.println("K���k olan say�:"+(say�1<say�2?say�1:say�2));

	}

}
