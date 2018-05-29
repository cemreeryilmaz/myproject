import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.GregorianCalendar;

public class Uygulama6 {

	public static void main(String[] args) {
		GregorianCalendar gc=new GregorianCalendar();
		Date þuankitarih=gc.getTime();
		System.out.println(þuankitarih);
		SimpleDateFormat sdf=new SimpleDateFormat("dd.MM.yy-hh:mm:ss");
		System.out.println(sdf.format(þuankitarih));
	}
}
