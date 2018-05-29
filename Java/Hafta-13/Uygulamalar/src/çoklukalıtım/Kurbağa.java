package çoklukalýtým;

public class Kurbaða implements SudaYaþayanlar,KaradaYaþayanlar{

	@Override
	public void akciðerSolunumuYap() {
		System.out.println("Kurbaða akciðer solunumu yaptý.");		
	}
	@Override
	public void solungaçSolunumuYap() {
		System.out.println("Kurbaða solungaç solunumu yaptý.");		
	}
	@Override
	public void avlan() {
		System.out.println("Kurbaða sinek avladý.");		
	}
}
