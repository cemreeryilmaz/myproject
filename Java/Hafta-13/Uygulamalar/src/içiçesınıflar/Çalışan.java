package i�i�es�n�flar;

public class �al��an {
	
	Adres adres=new Adres();
	
	public void adresBelirle(String sa,String ca,int bn,int dn){
		adres.adresBelirle(sa, ca, bn, dn);
	}
	public void getSokakAd�(){
		System.out.println("�al��an�n sokak ad�:"+this.adres.sokakad�);
	}
	
	private class Adres{
		
		int binano,daireno;
		String sokakad�,caddead�;
		
		public void adresBelirle(String sa,String ca,int bn,int dn){
			this.binano=bn;
			this.caddead�=ca;
			this.daireno=dn;
			this.sokakad�=sa;
		}
		
	}

}
