package abstractkelimesi;

public abstract class Hayvan {
	
	public abstract void avlan();//Soyut metot
	
	public void beslen(){//Somut metot
		System.out.println("Hayvan beslendi.");
	}
	//Abstract olarak tan�mlad���m�z s�n�f�n i�inde hem soyut
	//hem de somut metod kullanabiliriz.
}
