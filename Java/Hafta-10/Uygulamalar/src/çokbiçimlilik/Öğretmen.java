package çokbiçimlilik;

public class Öðretmen extends Çalýþan{

	String branþ;
	
	public Öðretmen(int sno, String ad, String s, double m) {
		super(sno, ad, s, m);
	}
	public static void çalýþ(){
		System.out.println("Öðretmen derse girdi...");
	}
}
