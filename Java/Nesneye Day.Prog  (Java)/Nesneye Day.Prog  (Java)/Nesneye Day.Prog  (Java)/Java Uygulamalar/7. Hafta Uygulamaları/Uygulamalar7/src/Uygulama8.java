import java.util.Date;
import java.util.Scanner;

public class Uygulama8 {

	public static void main(String[] args) {
String[]günler={"Pazar","Pazartesi","Salý","Çarþamba",
"Perþembe","Cuma","Cumartesi"};
Scanner klavye=new Scanner(System.in);
System.out.println("Günü giriniz:");
int gün=klavye.nextInt();
System.out.println("Ayý giriniz:");
int ay=klavye.nextInt();
System.out.println("Yýlý giriniz:");
int yýl=klavye.nextInt();
Date tarih=new Date(yýl-1900,ay-1,gün);
System.out.println("Doðduðunuz gün:"+
günler[tarih.getDay()]);
	}
}
