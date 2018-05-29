package statickullanýmý;

public class Uygulama4 {

	public static void main(String[] args) {
		Öðretmen öðretmen=new Öðretmen(1235, "Ayþe", "Kaya", 2500);
		System.out.println("Yukarý çevrimden önce adý:"+öðretmen.ad);
		System.out.println("Yukarý çevrimden önce soyadý:"+öðretmen.soyad);
		System.out.println("Yukarý çevrimden önce maaþý:"+öðretmen.maaþ);
		System.out.println("Yukarý çevrimden önce sigortano:"+öðretmen.sigortano);
		öðretmen.branþ="Beden Eðitimi";
		System.out.println("Yukarý çevrimden önce branþý:"+öðretmen.branþ);
		Çalýþan çalýþan=öðretmen;
		//Yukarý çevrimde casting yapýlmaz, referans gösterme iþlemine gerek yoktur.
		//Çünkü alt sýnýftan üst sýnýfa çevrilirken sadece bir ihtimal vardýr yani
		//sadece bir tane üst sýnýf vardýr. Ancak aþaðý çevrimde üst sýnýftan oluþturulan
		//nesnenin hangi alt sýnýfa çevrileceði belirsiz olduðu için referans gösterme
		//iþlemi zorunludur.
		System.out.println("Yukarý çevrimden sonra adý:"+çalýþan.ad);
		System.out.println("Yukarý çevrimden sonra soyadý:"+çalýþan.soyad);
		System.out.println("Yukarý çevrimden sonra maaþý:"+çalýþan.maaþ);
		System.out.println("Yukarý çevrimden sonra sigortano:"+çalýþan.sigortano);
		//çalýþan.branþ eriþilemez çünkü yukarý çevrimle nesne çalýþan nesnesi oldu.
	}
}
