import java.util.Scanner;


public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Sat�r say�s�:");
		int sat�rsay�s�=klavye.nextInt();
		System.out.println("S�tun say�s�:");
		int s�tunsay�s�=klavye.nextInt();
		int [][]dizi=new int[sat�rsay�s�][s�tunsay�s�];
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi[i].length; j++) {
				
				dizi[i][j]=i*dizi[i].length+(j+1);
			}
		}//Buraya kadar say�lar� yerle�tirdik.
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi[i].length; j++) {
				System.out.print(dizi[i][j]+"\t");
			}
			System.out.println();
		}}}
