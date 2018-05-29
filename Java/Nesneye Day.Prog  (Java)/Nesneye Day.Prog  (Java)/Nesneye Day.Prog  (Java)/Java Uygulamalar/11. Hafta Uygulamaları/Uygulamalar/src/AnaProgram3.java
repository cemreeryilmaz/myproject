import java.util.Scanner;

public class AnaProgram3 {

	public static void main(String[] args) {
		/*Çalýþan çalýþan1=new Çalýþan();
		Müdür müdür1=new Müdür();
		Memur memur1=new Memur();*/
		Öðretmen öðretmen1=new Öðretmen();
		Scanner klavye=new Scanner(System.in);
		/*çalýþan1.çalýþ();
		müdür1.çalýþ();
		memur1.çalýþ();*/
		System.out.println("Öðretmen kaç saat çalýþsýn?:");
		int saat=klavye.nextInt();
		öðretmen1.çalýþ(saat);		
	}
}
