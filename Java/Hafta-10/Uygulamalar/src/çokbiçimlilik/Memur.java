package çokbiçimlilik;

public class Memur extends Çalýþan{

	public Memur(int sno, String ad, String s, double m) {
		super(sno, ad, s, m);
	}
	public static void çalýþ(){//Method overriding 
		System.out.println("Memur döküman iþlerini yerine getirdi.");
	}
}
