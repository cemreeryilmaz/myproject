package Telefonlar;

public class CepTelefonu extends Telefon{

	@Override
	public void aramaYap() {
		System.out.println("G�r�nt�l� ve sesli g�r��me");		
	}
	//Telefon s�n�f�nda aramaYap metodu abstract oldu�u i�in
		//alt s�n�fta override edilmesi zorunludur.
}
