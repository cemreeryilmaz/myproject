package thisvesuperkullan�m�;

public class ��retmen extends �al��an {
	
	String kurum="myo";

	public ��retmen(String adsoyad, int sicilno, double maa�) {
		super(adsoyad, sicilno, maa�);//�st s�n�f�n yap�land�r�c� metodunu �a��r�r.		
	}

	public ��retmen(String adsoyad, int sicilno, double maa�, String kurum) {
		super(adsoyad, sicilno, maa�, kurum);//�st s�n�f�n yap�land�r�c� metodunu �a��r�r.		
	}
	public void konu�(){//Method overriding(metot ezme)
		System.out.println("Merhaba ben ��retmen, kurumum:"+this.kurum+" �st s�n�f�m�n kurumu:"+
				super.kurum);
		super.konu�();
	}

}
