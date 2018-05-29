package interfacesýnýflar;

public class Uygulama3 {

	public static void main(String[] args) {
		Aslan aslan=new Aslan();
		Kedi kedi=new Kedi();
		aslan.avlan();
		aslan.beslen();
		kedi.avlan();
		kedi.beslen();
		//avlan ve beslen metotlarý interface sýnýf olan Hayvan
		//sýnýfýnýn içinde bulunmaktadýr. Dolayýsýyla alt sýnýf
		//olan Aslan ve Kedi sýnýflarýnda override edilmek zorundadýr.
		//Interface sýnýf olan Hayvan sýnýfýndan kalýtýlan Aslan ve
		//Kedi sýnýflarý kalýtýmý implements anahtar kelimesi ile
		//yapmýþtýr.
	}
}
