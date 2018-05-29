package statickullanýmý;

public class Memur extends Çalýþan {

	public Memur(int sigortano, String ad, String soyad, double maaþ) {
		super(sigortano, ad, soyad, maaþ);
	}
	public static void evrakVer(){
		System.out.println("Memur evraðý verdi....");
	}
}
