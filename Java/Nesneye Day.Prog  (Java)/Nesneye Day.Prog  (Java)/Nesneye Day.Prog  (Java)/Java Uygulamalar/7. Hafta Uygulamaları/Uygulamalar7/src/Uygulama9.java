import java.util.Date;
import java.util.Scanner;


public class Uygulama9 {

	public static void main(String[] args) {
Scanner klavye=new Scanner(System.in);
System.out.println("1.tarihingünü:");
int güntarih1=klavye.nextInt();
System.out.println("1.tarihin ayý:");
int aytarih1=klavye.nextInt();
System.out.println("1.tarihin yýlý:");
int yýltarih1=klavye.nextInt();
Date tarih1=new Date(yýltarih1-1900,aytarih1-1,güntarih1);

System.out.println("2.tarihingünü:");
int güntarih2=klavye.nextInt();
System.out.println("2.tarihin ayý:");
int aytarih2=klavye.nextInt();
System.out.println("2.tarihin yýlý:");
int yýltarih2=klavye.nextInt();
Date tarih2=new Date(yýltarih2-1900,aytarih2-1,güntarih2);
	if(tarih1.compareTo(tarih2)==0){
		System.out.println("Tarihler eþit");
	}else if(tarih1.compareTo(tarih2)<0){
		System.out.println("Tarih1,Tarih2 den öncedir.");
	}else{
	System.out.println("Tarih2,Tarih1 den öncedir.");
		}	
	}
}
