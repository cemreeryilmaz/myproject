package interfaces�n�flar;

public class Uygulama3 {

	public static void main(String[] args) {
		Aslan aslan=new Aslan();
		Kedi kedi=new Kedi();
		aslan.avlan();
		aslan.beslen();
		kedi.avlan();
		kedi.beslen();
		//avlan ve beslen metotlar� interface s�n�f olan Hayvan
		//s�n�f�n�n i�inde bulunmaktad�r. Dolay�s�yla alt s�n�f
		//olan Aslan ve Kedi s�n�flar�nda override edilmek zorundad�r.
		//Interface s�n�f olan Hayvan s�n�f�ndan kal�t�lan Aslan ve
		//Kedi s�n�flar� kal�t�m� implements anahtar kelimesi ile
		//yapm��t�r.
	}
}
