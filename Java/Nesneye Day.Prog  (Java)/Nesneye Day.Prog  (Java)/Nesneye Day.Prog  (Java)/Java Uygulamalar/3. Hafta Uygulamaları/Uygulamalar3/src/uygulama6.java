import java.util.Scanner;

public class uygulama6 {

	public static void main(String[] args) {
	
	Scanner klavye=new Scanner(System.in);
	System.out.println("1-7 aras� say� giriniz:");
	int say�=klavye.nextInt();
	switch (say�) {
	case 1:
		System.out.println("Pazartesi");
		break;
	case 2:
		System.out.println("Sal�");
		break;
	case 3:
		System.out.println("�ar�amba");
	break;
	case 4:
		System.out.println("Per�embe");
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
		System.out.println("Hatal� Giri�");
		break;
	}

	}

}
