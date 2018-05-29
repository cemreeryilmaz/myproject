import java.util.Scanner;


public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Satýr sayýsý:");
		int satýrsayýsý=klavye.nextInt();
		System.out.println("Sütun sayýsý:");
		int sütunsayýsý=klavye.nextInt();
		int [][]dizi=new int[satýrsayýsý][sütunsayýsý];
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi[i].length; j++) {
				
				dizi[i][j]=i*dizi[i].length+(j+1);
			}
		}//Buraya kadar sayýlarý yerleþtirdik.
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi[i].length; j++) {
				System.out.print(dizi[i][j]+"\t");
			}
			System.out.println();
		}}}
