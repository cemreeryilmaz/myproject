package abstractkelimesi;

public class Aslan extends Hayvan {

	@Override
	public void avlan() {
		System.out.println("Aslan ceylan avladý");		
	}
	//Abstract Hayvan sýnýfýnýn avlan metodu soyut olduðu için
	//alt sýnýflarda(Aslan, Kedi) override edilmesi zorunludur.
	//Ancak beslen metodu somut bir metot olduðu için alt
	//sýnýflarda override edilmesi zorunlu deðil.
}
