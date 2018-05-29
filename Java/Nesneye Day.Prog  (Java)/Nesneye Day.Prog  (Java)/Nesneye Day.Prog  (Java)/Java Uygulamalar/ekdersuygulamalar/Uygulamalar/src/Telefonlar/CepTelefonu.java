package Telefonlar;

public class CepTelefonu extends Telefon{

	@Override
	public void aramaYap() {
		System.out.println("Görüntülü ve sesli görüþme");		
	}
	//Telefon sýnýfýnda aramaYap metodu abstract olduðu için
		//alt sýnýfta override edilmesi zorunludur.
}
