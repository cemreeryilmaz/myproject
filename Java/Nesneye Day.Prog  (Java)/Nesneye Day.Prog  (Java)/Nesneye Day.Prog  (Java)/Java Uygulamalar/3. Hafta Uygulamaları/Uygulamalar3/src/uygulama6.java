import java.util.Scanner;

public class uygulama6 {

	public static void main(String[] args) {
	
	Scanner klavye=new Scanner(System.in);
	System.out.println("1-7 arasý sayý giriniz:");
	int sayý=klavye.nextInt();
	switch (sayý) {
	case 1:
		System.out.println("Pazartesi");
		break;
	case 2:
		System.out.println("Salý");
		break;
	case 3:
		System.out.println("Çarþamba");
	break;
	case 4:
		System.out.println("Perþembe");
	break;
	case 5:
		System.out.println("Cuma");
	break;
	case 6:
		System.out.println("Cumartesi");
	break;
	case 7:
		System.out.println("Pazar");
	break;

	default:
		System.out.println("Hatalý Giriþ");
		break;
	}

	}

}
