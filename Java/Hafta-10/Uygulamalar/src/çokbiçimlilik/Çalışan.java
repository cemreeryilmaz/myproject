package �okbi�imlilik;

public class �al��an {
	
	int sigortano;
	String ad;
	String soyad;
	double maa�;
	static String kurum="Arel";
	
	public �al��an(int sno,String ad,String s,double m){
		sigortano=sno;
		this.ad=ad;
		soyad=s;
		maa�=m;
	}
	
	public static void �al��(){
		System.out.println("�al��an �al��t�.");
	}

}
