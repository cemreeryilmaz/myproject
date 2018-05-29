
public class Uygulama2 {

	public static void main(String[] args) {
		int[]dizi=new int[10];
		for (int i = 0; i < dizi.length+1; i++) {
			try {
				System.out.println(dizi[i]);
			} catch (ArrayIndexOutOfBoundsException e) {
				System.out.println("Yanlýþ dizi eriþimi");
			}			
		}
	}
}
