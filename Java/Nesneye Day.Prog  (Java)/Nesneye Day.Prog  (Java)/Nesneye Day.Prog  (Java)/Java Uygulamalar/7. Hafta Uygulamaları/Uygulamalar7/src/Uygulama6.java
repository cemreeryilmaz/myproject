import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.GregorianCalendar;

public class Uygulama6 {

	public static void main(String[] args) {
		GregorianCalendar gc=new GregorianCalendar();
		Date �uankitarih=gc.getTime();
		System.out.println(�uankitarih);
		SimpleDateFormat sdf=new SimpleDateFormat("dd.MM.yy-hh:mm:ss");
		System.out.println(sdf.format(�uankitarih));
	}
}
