package abstractkelimesi;

public abstract class Hayvan {
	
	public abstract void avlan();//Soyut metot
	
	public void beslen(){//Somut metot
		System.out.println("Hayvan beslendi.");
	}
	//Abstract olarak tanýmladýðýmýz sýnýfýn içinde hem soyut
	//hem de somut metod kullanabiliriz.
}
