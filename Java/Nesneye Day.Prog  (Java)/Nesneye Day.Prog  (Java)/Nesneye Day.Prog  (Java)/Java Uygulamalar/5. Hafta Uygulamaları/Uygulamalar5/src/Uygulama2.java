import java.util.Random;

public class Uygulama2 {

	public static void main(String[] args) {
		Random rasgele=new Random();
		byte[]dizi=new byte[10];
		for (int i = 0; i < dizi.length; i++) {
			dizi[i]=(byte) rasgele.nextInt(101);
		}
		//1. Y�ntem:
		/*for (int i = 0; i < dizi.length; i++) {
			System.out.print(dizi[i]+" ");
		}*/
		//2.Y�ntem
		for (byte ge�ici : dizi) {
			System.out.print(ge�ici+" ");
		}
	}
}
