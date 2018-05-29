import java.util.Scanner;

public class uygulama2 {

	public static void main(String[] args) {
		Scanner giriþ=new Scanner(System.in);
		System.out.println("1.sayýyý giriniz:");
		int sayý1=giriþ.nextInt();
		if (sayý1==1) {
			System.out.println("2.sayýyý giriniz:");
			int sayý2=giriþ.nextInt();
			if (sayý2==2) {
				System.out.println("3.sayýyý giriniz:");
				int sayý3=giriþ.nextInt();
				if (sayý3==3) {
					System.out.println("Doðru Giriþ");
				}			
		} 
	}
		else {
			System.out.println("Yanlýþ Giriþ");
		}

}
}
