package Telefonlar;

public class EvTelefonu extends Telefon{

	@Override
	public void aramaYap() {
		System.out.println("Sesli g�r��me");		
	}
	//Telefon s�n�f�nda aramaYap metodu abstract oldu�u i�in
	//alt s�n�fta override edilmesi zorunludur.
}
