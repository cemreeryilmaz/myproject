import java.util.Date;
import java.util.GregorianCalendar;

public class Uygulama7 {

public static void main(String[] args) {
String[]günler={"Pazar","Pazartesi","Salý","Çarþamba",
"Perþembe","Cuma","Cumartesi"};
String[]aylar={"Ocak","Þubat","Mart","Nisan","Mayýs",
"Haziran","Temmuz","Aðustos","Eylül","Ekim",
"Kasým","Aralýk"};
GregorianCalendar gc=new GregorianCalendar();
Date þuankitarih=gc.getTime();
System.out.println("Haftanýn günü:"+günler[þuankitarih.getDay()]);
System.out.println("Ayýn günü:"+þuankitarih.getDate());
System.out.println("Ay:"+aylar[þuankitarih.getMonth()]);
System.out.println("Yýl:"+(þuankitarih.getYear()+1900));
	}
}
