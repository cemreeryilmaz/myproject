package diziler;

import java.util.Random;

public class Uygulama1 {

	public static void main(String[] args) {
		Random rasgele=new Random();
		int[]dizi=new int[10];
		for (int i = 0; i < dizi.length; i++) {
			dizi[i]=rasgele.nextInt(100);
		}
		/*for (int i = 0; i < dizi.length; i++) {
			System.out.print(dizi[i]+"\t");
		}*/
		for (int i : dizi) {
			System.out.print(i+"\t");
		}
	}
}
