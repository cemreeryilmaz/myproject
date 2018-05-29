import java.util.Scanner;

public class AnaProgram5 {
	
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Öðretmen kaç saat çalýþsýn?:");
		int saat=klavye.nextInt();
		Öðretmen.çalýþ(saat);		
	}
	public void programýSonlandýr(){
		main(null);		
	}
}
