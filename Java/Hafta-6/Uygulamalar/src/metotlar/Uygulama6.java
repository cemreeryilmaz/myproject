package metotlar;

import java.util.Arrays;

public class Uygulama6 {

	public static void main(String[] args) {
		int[]dizi=new int[10];
		for (int i = 0; i < dizi.length; i++) {
			dizi[i]=(int) (Math.random()*100);
		}
		int[]s�ralanm��dizi=diziS�rala(dizi);
		for (int i : s�ralanm��dizi) {
			System.out.print(i+"\t");
		}
	}
	private static int[] diziS�rala(int[] dizi) {
		Arrays.sort(dizi);
		return dizi;
	}           
}