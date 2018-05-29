package interfacesýnýflar;

public class Kedi implements Hayvan{

	@Override
	public void avlan() {
		System.out.println("Kedi fare yakaladý.");		
	}
	@Override
	public void beslen() {
		System.out.println("Kedi beslendi.");		
	}
}
