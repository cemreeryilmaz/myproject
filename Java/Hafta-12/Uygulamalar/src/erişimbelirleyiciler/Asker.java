package eri�imbelirleyiciler;

public class Asker {
	
	String r�tbe="Asker";//default
	private double maa�;
	protected String s�n�f;
	public String adsoyad;
	
	public void selamVer(){
	System.out.println("Asker selam verdi.");	
	}	
	public void bilgiVer(){
		System.out.println("Merhaba ad�m: "+this.adsoyad+" Maa��m:"+this.maa�+
				"S�n�f�m: "+this.s�n�f+" R�tbem:"+this.r�tbe);
	}//eri�im belirleyicisi ne olursa olsun s�n�f i�erisinden istenilen �zellik
	//ve metoda eri�im m�mk�nd�r.
	public double getMaa�() {
		return maa�;
	}
	public void setMaa�(double maa�) {
		this.maa� = maa�;
	}
	
}
