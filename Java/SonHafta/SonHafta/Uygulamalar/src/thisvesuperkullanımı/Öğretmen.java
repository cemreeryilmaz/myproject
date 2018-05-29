package thisvesuperkullanýmý;

public class Öðretmen extends Çalýþan {
	
	String kurum="myo";

	public Öðretmen(String adsoyad, int sicilno, double maaþ) {
		super(adsoyad, sicilno, maaþ);//üst sýnýfýn yapýlandýrýcý metodunu çaðýrýr.		
	}

	public Öðretmen(String adsoyad, int sicilno, double maaþ, String kurum) {
		super(adsoyad, sicilno, maaþ, kurum);//üst sýnýfýn yapýlandýrýcý metodunu çaðýrýr.		
	}
	public void konuþ(){//Method overriding(metot ezme)
		System.out.println("Merhaba ben öðretmen, kurumum:"+this.kurum+" üst sýnýfýmýn kurumu:"+
				super.kurum);
		super.konuþ();
	}

}
