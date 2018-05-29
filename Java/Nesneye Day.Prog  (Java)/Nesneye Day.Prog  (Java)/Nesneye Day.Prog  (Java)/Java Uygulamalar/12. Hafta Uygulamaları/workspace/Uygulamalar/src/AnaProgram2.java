
public class AnaProgram2 {
	
	public static void main(String[] args) {
		/*Öðretmen öðretmen1=new Öðretmen();
		öðretmen1.dersAnlat();
		öðretmen1.çalýþ();
		System.out.println("Öðretmenin çalýþma saati:"+öðretmen1.saatSöyle());
		
		Çalýþan öðretmen2=öðretmen1;//Yukarý Çevrim (UpCasting)
*/		
		Çalýþan çalýþan1=new Öðretmen();
		//Aþaðý çevrim yapmak istiyorsak çevrim yapmadan önce
		//üst sýnýftan oluþturduðumuz nesneyi çevrim yapacaðýmýz alt sýnýfa
		//referans göstermek zorundayýz, aksi halde hata alýrýz.
		çalýþan1.çalýþ();
		
		
		Öðretmen ayþe=(Öðretmen) çalýþan1;
		ayþe.dersAnlat();
	}
}
