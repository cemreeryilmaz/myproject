import java.util.Date;
import java.util.Scanner;

public class Uygulama8 {

	public static void main(String[] args) {
String[]g�nler={"Pazar","Pazartesi","Sal�","�ar�amba",
"Per�embe","Cuma","Cumartesi"};
Scanner klavye=new Scanner(System.in);
System.out.println("G�n� giriniz:");
int g�n=klavye.nextInt();
System.out.println("Ay� giriniz:");
int ay=klavye.nextInt();
System.out.println("Y�l� giriniz:");
int y�l=klavye.nextInt();
Date tarih=new Date(y�l-1900,ay-1,g�n);
System.out.println("Do�du�unuz g�n:"+
g�nler[tarih.getDay()]);
	}
}
