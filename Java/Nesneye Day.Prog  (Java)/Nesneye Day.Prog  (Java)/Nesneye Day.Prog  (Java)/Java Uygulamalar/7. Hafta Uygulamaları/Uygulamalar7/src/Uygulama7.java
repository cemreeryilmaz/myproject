import java.util.Date;
import java.util.GregorianCalendar;

public class Uygulama7 {

public static void main(String[] args) {
String[]g�nler={"Pazar","Pazartesi","Sal�","�ar�amba",
"Per�embe","Cuma","Cumartesi"};
String[]aylar={"Ocak","�ubat","Mart","Nisan","May�s",
"Haziran","Temmuz","A�ustos","Eyl�l","Ekim",
"Kas�m","Aral�k"};
GregorianCalendar gc=new GregorianCalendar();
Date �uankitarih=gc.getTime();
System.out.println("Haftan�n g�n�:"+g�nler[�uankitarih.getDay()]);
System.out.println("Ay�n g�n�:"+�uankitarih.getDate());
System.out.println("Ay:"+aylar[�uankitarih.getMonth()]);
System.out.println("Y�l:"+(�uankitarih.getYear()+1900));
	}
}
