package �okbi�imlilik;

public class Memur extends �al��an{

	public Memur(int sno, String ad, String s, double m) {
		super(sno, ad, s, m);
	}
	public static void �al��(){//Method overriding 
		System.out.println("Memur d�k�man i�lerini yerine getirdi.");
	}
}
