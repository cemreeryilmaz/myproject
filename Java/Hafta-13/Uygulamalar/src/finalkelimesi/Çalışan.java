package finalkelimesi;

public final class Çalýþan {
	
	String adsoyad;
	final String kurum="Arel";
	int sicilno;
	double maaþ;
	Adres adres=new Adres();
	
	public final void çalýþ(){
		System.out.println("Çalýþan görevini yerine getirdi.");
	}
	public void adresBelirle(String sokakadý,String caddeadý,int binano,int daireno){
		this.adres.binano=binano;
		this.adres.daireno=daireno;
		this.adres.caddeadý=caddeadý;
		this.adres.sokakadý=sokakadý;
	}
	/*public void çalýþ(){
		
	}*/

}
