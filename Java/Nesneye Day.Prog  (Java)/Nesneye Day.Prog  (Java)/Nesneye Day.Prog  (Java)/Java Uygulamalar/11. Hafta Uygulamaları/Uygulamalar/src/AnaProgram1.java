import java.util.Scanner;

public class AnaProgram1 {
public static void main(String[] args) {
Scanner klavye=new Scanner(System.in);
HesapMakinesi hm=new HesapMakinesi();
System.out.println("1.say�y� giriniz:");
double say�1=klavye.nextDouble();
System.out.println("2.say�y� giriniz:");
double say�2=klavye.nextDouble();
System.out.println("Toplama i�in[1]\n��karma i�in[2]\nB�lme i�in[3]\n�arpma i�in[4]");
byte tercih=klavye.nextByte();
if(tercih==1){
	System.out.println("Sonu�:"+hm.toplamaYap(say�1, say�2));
}
else if(tercih==2){
	System.out.println("Sonu�:"+hm.��karmaYap(say�1, say�2));
}
else if(tercih==3){
	System.out.println("Sonu�:"+hm.b�lmeYap(say�1, say�2));
}
else if(tercih==4){
	System.out.println("Sonu�:"+hm.�arpmaYap(say�1, say�2));
}
else{
	System.out.println("Hatal� i�lem se�imi");
}
}
}
