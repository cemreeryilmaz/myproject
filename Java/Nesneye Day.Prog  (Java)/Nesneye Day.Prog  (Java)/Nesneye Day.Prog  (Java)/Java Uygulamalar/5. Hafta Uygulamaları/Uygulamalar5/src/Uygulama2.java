import java.util.Random;

public class Uygulama2 {

	public static void main(String[] args) {
		Random rasgele=new Random();
		byte[]dizi=new byte[10];
		for (int i = 0; i < dizi.length; i++) {
			dizi[i]=(byte) rasgele.nextInt(101);
		}
		//1. Yöntem:
		/*for (int i = 0; i < dizi.length; i++) {
			System.out.print(dizi[i]+" ");
		}*/
		//2.Yöntem
		for (byte geçici : dizi) {
			System.out.print(geçici+" ");
		}
	}
}
