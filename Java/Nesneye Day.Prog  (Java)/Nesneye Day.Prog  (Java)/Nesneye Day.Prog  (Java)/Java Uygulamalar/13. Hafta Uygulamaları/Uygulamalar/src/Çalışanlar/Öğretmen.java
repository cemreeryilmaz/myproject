package �al��anlar;

public class ��retmen extends �al��an{
	String g�revi="��retmen";	
	public ��retmen(int sicilno, String ad, String soyad, double maa�) {
		super(sicilno,ad,soyad,maa�);
	}	
	public void adS�yle(){
		System.out.println(this.ad);
		System.out.println(super.ad);
	}
	public void �al��t�r(int saat){
		super.�al��(saat);
	}
	public void konu�(){
		System.out.println("Merhaba ben ��retmen");
	}
}
