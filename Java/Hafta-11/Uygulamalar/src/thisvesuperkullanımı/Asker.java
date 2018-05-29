package thisvesuperkullanýmý;

public class Asker {
	
	String adsoyad,rütbe="Asker",sýnýf;
	double maaþ;
	public Asker(String adsoyad, String rütbe, String sýnýf) {
		this.adsoyad = adsoyad;//this kelimesi sýnýfýn özelliðini çaðýrmak için
		this.rütbe = rütbe;
		this.sýnýf = sýnýf;
		this.selamVer();//sýnýfýn baþka metodunu çaðýrmak için
	}
	public Asker(String adsoyad, String rütbe, String sýnýf, double maaþ) {
		this(adsoyad, rütbe, sýnýf);//farklý yapýlandýrýcý metod çaðýrmak için
		this.maaþ = maaþ;
	}
	public void selamVer(){
		System.out.println("Asker selam verdi...");
		this.rütbe="Asker";
	}
}
