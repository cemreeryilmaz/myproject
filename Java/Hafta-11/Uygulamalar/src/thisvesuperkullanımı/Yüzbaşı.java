package thisvesuperkullan�m�;

public class Y�zba�� extends Asker {

	public Y�zba��(String adsoyad, String r�tbe, String s�n�f) {
		super(adsoyad, r�tbe, s�n�f);//�st s�n�f�n yap�land�r�c� metodunu �a��r�r.
	}
	
	public Y�zba��(String adsoyad, String r�tbe, String s�n�f, double maa�) {
		super(adsoyad, r�tbe, s�n�f, maa�);//�st s�n�f�n yap�land�r�c� metodunu �a��r�r.
	}
	public void r�tbeS�yle(){
		System.out.println("Merhaba, ben "+this.r�tbe+" �st s�n�f�m�n "
				+ "r�tbe �zelli�i:"+super.r�tbe);
	}
}
