package kompozisyon;

public class �al��an {
	
	String adsoyad;
	String kurum;
	int sicilno;
	double maa�;
	Adres adres=new Adres();
	
	public void �al��(){
		System.out.println("�al��an g�revini yerine getirdi.");
	}
	public void adresBelirle(String sokakad�,String caddead�,int binano,int daireno){
		this.adres.binano=binano;
		this.adres.daireno=daireno;
		this.adres.caddead�=caddead�;
		this.adres.sokakad�=sokakad�;
	}

}
