package finalkelimesi;

public final class �al��an {
	
	String adsoyad;
	final String kurum="Arel";
	int sicilno;
	double maa�;
	Adres adres=new Adres();
	
	public final void �al��(){
		System.out.println("�al��an g�revini yerine getirdi.");
	}
	public void adresBelirle(String sokakad�,String caddead�,int binano,int daireno){
		this.adres.binano=binano;
		this.adres.daireno=daireno;
		this.adres.caddead�=caddead�;
		this.adres.sokakad�=sokakad�;
	}
	/*public void �al��(){
		
	}*/

}
