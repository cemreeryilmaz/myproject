
public class �al��an {
	
	int sigortano;
	String ad�;
	String soyad�;
	double maa�;
	
	public �al��an(){
		
	}	
	public �al��an(int sigortano,String ad�){
		this.sigortano=sigortano;
		this.ad�=ad�;
	}	
	public �al��an(int sigortano,String ad�,String soyad�,double maa�){
		this(sigortano,ad�);//�ki parametre alan yap�land�r�c� metodu �a��r�r.
		this.soyad�=soyad�;
		this.maa�=maa�;
	}	
	public void �al��mas�n�S�yle(){
		this.�al��();//S�n�f�n i�inde bulunan �al�� isimli metodu �a��r�r.
	}
	public void �al��(){
		System.out.println("�al��an s�n�f� �al��t�");
	}
}
