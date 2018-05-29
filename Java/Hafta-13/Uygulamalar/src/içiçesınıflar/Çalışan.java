package içiçesýnýflar;

public class Çalýþan {
	
	Adres adres=new Adres();
	
	public void adresBelirle(String sa,String ca,int bn,int dn){
		adres.adresBelirle(sa, ca, bn, dn);
	}
	public void getSokakAdý(){
		System.out.println("Çalýþanýn sokak adý:"+this.adres.sokakadý);
	}
	
	private class Adres{
		
		int binano,daireno;
		String sokakadý,caddeadý;
		
		public void adresBelirle(String sa,String ca,int bn,int dn){
			this.binano=bn;
			this.caddeadý=ca;
			this.daireno=dn;
			this.sokakadý=sa;
		}
		
	}

}
