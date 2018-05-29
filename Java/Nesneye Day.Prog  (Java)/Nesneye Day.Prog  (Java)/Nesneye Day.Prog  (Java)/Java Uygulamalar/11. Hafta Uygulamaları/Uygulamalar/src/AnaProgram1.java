import java.util.Scanner;

public class AnaProgram1 {
public static void main(String[] args) {
Scanner klavye=new Scanner(System.in);
HesapMakinesi hm=new HesapMakinesi();
System.out.println("1.sayýyý giriniz:");
double sayý1=klavye.nextDouble();
System.out.println("2.sayýyý giriniz:");
double sayý2=klavye.nextDouble();
System.out.println("Toplama için[1]\nÇýkarma için[2]\nBölme için[3]\nÇarpma için[4]");
byte tercih=klavye.nextByte();
if(tercih==1){
	System.out.println("Sonuç:"+hm.toplamaYap(sayý1, sayý2));
}
else if(tercih==2){
	System.out.println("Sonuç:"+hm.çýkarmaYap(sayý1, sayý2));
}
else if(tercih==3){
	System.out.println("Sonuç:"+hm.bölmeYap(sayý1, sayý2));
}
else if(tercih==4){
	System.out.println("Sonuç:"+hm.çarpmaYap(sayý1, sayý2));
}
else{
	System.out.println("Hatalý iþlem seçimi");
}
}
}
