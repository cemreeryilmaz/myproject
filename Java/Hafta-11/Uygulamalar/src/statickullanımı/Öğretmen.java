package statickullanýmý;

public class Öðretmen extends Çalýþan {
	
	String branþ;

	public Öðretmen(int sigortano, String ad, String soyad, double maaþ) {
		super(sigortano, ad, soyad, maaþ);
	}
	public void çalýþ(){
		System.out.println("Öðretmen derse girdi...");
	}
}
