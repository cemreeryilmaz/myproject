
public class Öğretmen extends Çalışan{
	String uzmanlıkalanı="Tarih";
	int çalışmasaati=8;
	
	public int saatSöyle(){
		return çalışmasaati;
	}
	public void dersAnlat(){
		System.out.println("Öğretmen ders anlattı.");
	}

}
