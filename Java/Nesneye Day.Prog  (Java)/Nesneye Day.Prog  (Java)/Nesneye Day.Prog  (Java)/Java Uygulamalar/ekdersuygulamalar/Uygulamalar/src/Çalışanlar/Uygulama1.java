package �al��anlar;

public class Uygulama1 {

	public static void main(String[] args) {
		�al��an ahmet=new �al��an();
		ahmet.adres.kap�no=10;
		M�d�r mehmet=new M�d�r();
		mehmet.adres.cadde="Halkal� caddesi";
		//�al��an s�n�f�n�n i�inde Adres s�n�f�na ait bir nesne
		//oldu�u i�in �al��an s�n�f� ile Adres s�n�f� aras�nda
		//sahip olma (HAS-A) ili�kisi vard�r. Buna kompozisyon
		// da denir.
	}
}
