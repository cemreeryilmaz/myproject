import java.util.Date;
import java.util.Scanner;


public class Uygulama9 {

	public static void main(String[] args) {
Scanner klavye=new Scanner(System.in);
System.out.println("1.tarihing�n�:");
int g�ntarih1=klavye.nextInt();
System.out.println("1.tarihin ay�:");
int aytarih1=klavye.nextInt();
System.out.println("1.tarihin y�l�:");
int y�ltarih1=klavye.nextInt();
Date tarih1=new Date(y�ltarih1-1900,aytarih1-1,g�ntarih1);

System.out.println("2.tarihing�n�:");
int g�ntarih2=klavye.nextInt();
System.out.println("2.tarihin ay�:");
int aytarih2=klavye.nextInt();
System.out.println("2.tarihin y�l�:");
int y�ltarih2=klavye.nextInt();
Date tarih2=new Date(y�ltarih2-1900,aytarih2-1,g�ntarih2);
	if(tarih1.compareTo(tarih2)==0){
		System.out.println("Tarihler e�it");
	}else if(tarih1.compareTo(tarih2)<0){
		System.out.println("Tarih1,Tarih2 den �ncedir.");
	}else{
	System.out.println("Tarih2,Tarih1 den �ncedir.");
		}	
	}
}
