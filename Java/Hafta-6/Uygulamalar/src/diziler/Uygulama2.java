package diziler;

import java.util.Scanner;

public class Uygulama2 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Satýr adedini giriniz:");
		int satýradedi=klavye.nextInt();
		System.out.println("Sütun adedini giriniz:");
		int sütunadedi=klavye.nextInt();
		System.out.println("Baþlangýç deðerini giriniz:");
		int baþlangýçdeðeri=klavye.nextInt();
		int[][]dizi=new int[satýradedi][sütunadedi];
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi[i].length; j++) {
				dizi[i][j]=baþlangýçdeðeri;
				baþlangýçdeðeri++;
			}
		}
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi[i].length; j++) {
				System.out.print(dizi[i][j]+"\t");
			}
			System.out.println();
		}
	}
}
