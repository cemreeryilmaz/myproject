package �oklukal�t�m;

public class Kurba�a implements SudaYa�ayanlar,KaradaYa�ayanlar{

	@Override
	public void akci�erSolunumuYap() {
		System.out.println("Kurba�a akci�er solunumu yapt�.");		
	}
	@Override
	public void solunga�SolunumuYap() {
		System.out.println("Kurba�a solunga� solunumu yapt�.");		
	}
	@Override
	public void avlan() {
		System.out.println("Kurba�a sinek avlad�.");		
	}
}
