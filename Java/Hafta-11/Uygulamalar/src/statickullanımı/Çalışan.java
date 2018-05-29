package statickullanýmý;

public class Çalýþan {
	
	int sigortano;
	String ad,soyad;
	double maaþ;
	static String kurum="Arel Üniversitesi";
	
	public Çalýþan(int sigortano, String ad, String soyad, double maaþ) {
		this.sigortano = sigortano;
		this.ad = ad;
		this.soyad = soyad;
		this.maaþ = maaþ;
	}
	public void çalýþ(){
		System.out.println("Çalýþan görevini yerine getirdi.");
	}
}
