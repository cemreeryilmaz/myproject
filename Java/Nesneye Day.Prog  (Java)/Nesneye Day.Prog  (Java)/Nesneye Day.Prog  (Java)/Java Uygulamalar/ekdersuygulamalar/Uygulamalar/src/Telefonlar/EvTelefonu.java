package Telefonlar;

public class EvTelefonu extends Telefon{

	@Override
	public void aramaYap() {
		System.out.println("Sesli görüþme");		
	}
	//Telefon sýnýfýnda aramaYap metodu abstract olduðu için
	//alt sýnýfta override edilmesi zorunludur.
}
