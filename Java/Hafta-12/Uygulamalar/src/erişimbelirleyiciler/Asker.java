package eriþimbelirleyiciler;

public class Asker {
	
	String rütbe="Asker";//default
	private double maaþ;
	protected String sýnýf;
	public String adsoyad;
	
	public void selamVer(){
	System.out.println("Asker selam verdi.");	
	}	
	public void bilgiVer(){
		System.out.println("Merhaba adým: "+this.adsoyad+" Maaþým:"+this.maaþ+
				"Sýnýfým: "+this.sýnýf+" Rütbem:"+this.rütbe);
	}//eriþim belirleyicisi ne olursa olsun sýnýf içerisinden istenilen özellik
	//ve metoda eriþim mümkündür.
	public double getMaaþ() {
		return maaþ;
	}
	public void setMaaþ(double maaþ) {
		this.maaþ = maaþ;
	}
	
}
