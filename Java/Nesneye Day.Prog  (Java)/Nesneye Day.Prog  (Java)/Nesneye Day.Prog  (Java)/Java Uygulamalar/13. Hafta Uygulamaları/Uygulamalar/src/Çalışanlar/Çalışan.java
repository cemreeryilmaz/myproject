package �al��anlar;

public class �al��an {
protected int sicilno;
public String ad="�al��an Ki�i";
private String soyad;
double maa�;


public String getSoyad() {
	return soyad;
}
public void setSoyad(String soyad) {
	this.soyad = soyad;
}
public �al��an(int sicilno, String ad, String soyad, double maa�) {
	this.sicilno = sicilno;
	this.ad = ad;
	this.soyad = soyad;
	this.maa� = maa�;
}
public void �al��(int saat){
	System.out.println("�al��an "+ saat+" saat �al��t�.");
}
public void konu�(){
	System.out.println("Merhaba ben �al��an");
}

}
