package thisvesuperkullan�m�;

public class Asker {
	
	String adsoyad,r�tbe="Asker",s�n�f;
	double maa�;
	public Asker(String adsoyad, String r�tbe, String s�n�f) {
		this.adsoyad = adsoyad;//this kelimesi s�n�f�n �zelli�ini �a��rmak i�in
		this.r�tbe = r�tbe;
		this.s�n�f = s�n�f;
		this.selamVer();//s�n�f�n ba�ka metodunu �a��rmak i�in
	}
	public Asker(String adsoyad, String r�tbe, String s�n�f, double maa�) {
		this(adsoyad, r�tbe, s�n�f);//farkl� yap�land�r�c� metod �a��rmak i�in
		this.maa� = maa�;
	}
	public void selamVer(){
		System.out.println("Asker selam verdi...");
		this.r�tbe="Asker";
	}
}
