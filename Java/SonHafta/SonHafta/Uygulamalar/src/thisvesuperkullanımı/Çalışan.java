package thisvesuperkullan�m�;

public class �al��an {
	
	String adsoyad;
	int sicilno;
	double maa�;
	String kurum="Arel";
	
	public �al��an(String adsoyad, int sicilno, double maa�) {
		this.adsoyad = adsoyad;//s�n�f�n i�erisinden s�n�fa ait �zelli�i �a��r�r.
		this.sicilno = sicilno;
		this.maa� = maa�;
		//this.konu�();//s�n�f�n i�erisinden s�n�fa ait metodu �a��r�r.
	}	
	
	public �al��an(String adsoyad, int sicilno, double maa�, String kurum) {
		this(adsoyad,sicilno,maa�);//s�n�f�n i�erisinden yap�land�r�c� metodu �a��r�r.
		this.kurum = kurum;
	}

	public void konu�(){
		System.out.println("�al��an�n ad�soyad�:"+this.adsoyad);
		System.out.println("�al��an�n sicil numaras�:"+this.sicilno);
		System.out.println("�al��an�n maa��:"+this.maa�);
		System.out.println("�al��an�n kurumu:"+this.kurum);
	}
	
	
}
