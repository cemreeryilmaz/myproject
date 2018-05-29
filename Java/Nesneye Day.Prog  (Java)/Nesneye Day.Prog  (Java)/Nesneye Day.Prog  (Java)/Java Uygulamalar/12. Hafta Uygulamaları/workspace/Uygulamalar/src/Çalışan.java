
public class Çalýþan {
	
	int sigortano;
	String adý;
	String soyadý;
	double maaþ;
	
	public Çalýþan(){
		
	}	
	public Çalýþan(int sigortano,String adý){
		this.sigortano=sigortano;
		this.adý=adý;
	}	
	public Çalýþan(int sigortano,String adý,String soyadý,double maaþ){
		this(sigortano,adý);//Ýki parametre alan yapýlandýrýcý metodu çaðýrýr.
		this.soyadý=soyadý;
		this.maaþ=maaþ;
	}	
	public void çalýþmasýnýSöyle(){
		this.çalýþ();//Sýnýfýn içinde bulunan çalýþ isimli metodu çaðýrýr.
	}
	public void çalýþ(){
		System.out.println("Çalýþan sýnýfý çalýþtý");
	}
}
