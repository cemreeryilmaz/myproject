package abstractkelimesi;

public class Aslan extends Hayvan {

	@Override
	public void avlan() {
		System.out.println("Aslan ceylan avlad�");		
	}
	//Abstract Hayvan s�n�f�n�n avlan metodu soyut oldu�u i�in
	//alt s�n�flarda(Aslan, Kedi) override edilmesi zorunludur.
	//Ancak beslen metodu somut bir metot oldu�u i�in alt
	//s�n�flarda override edilmesi zorunlu de�il.
}
