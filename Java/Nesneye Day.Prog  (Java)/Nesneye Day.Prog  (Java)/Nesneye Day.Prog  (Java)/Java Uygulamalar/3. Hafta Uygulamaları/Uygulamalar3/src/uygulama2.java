import java.util.Scanner;

public class uygulama2 {

	public static void main(String[] args) {
		Scanner giri�=new Scanner(System.in);
		System.out.println("1.say�y� giriniz:");
		int say�1=giri�.nextInt();
		if (say�1==1) {
			System.out.println("2.say�y� giriniz:");
			int say�2=giri�.nextInt();
			if (say�2==2) {
				System.out.println("3.say�y� giriniz:");
				int say�3=giri�.nextInt();
				if (say�3==3) {
					System.out.println("Do�ru Giri�");
				}			
		} 
	}
		else {
			System.out.println("Yanl�� Giri�");
		}

}
}
