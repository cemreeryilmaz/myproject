package Çalýþanlar;

public class Uygulama2 {

	public static void main(String[] args) {
		Öðretmen ayþe=new Öðretmen();
		ayþe.uzmanlýkalaný="Tarih";
		//uzmanlýkalaný deðiþkeni final olduðu için
		//deðeri deðiþtirilemez.
		String kelime=ayþe.uzmanlýkalaný;
		//uzmanlýkalaný final olsa da eriþilebilir ama
		//final deðiþkenin deðeri deðiþtirilemez.
		Çalýþan yeniçalýþan=new Çalýþan();
		yeniçalýþan.tcno="1234545";
		
	}
}
