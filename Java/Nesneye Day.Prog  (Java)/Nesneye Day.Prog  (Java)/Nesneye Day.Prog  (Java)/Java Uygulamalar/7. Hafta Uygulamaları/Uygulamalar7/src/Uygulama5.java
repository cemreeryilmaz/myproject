import java.util.Scanner;

public class Uygulama5 {

	public static void main(String[] args) {
		int[]dizi = null;
		Scanner klavye=new Scanner(System.in);
		try {
			System.out.println(dizi[0]);
		} catch (Exception e) {
			System.out.println("Dizi boþ");
		}		
		System.out.println("Dizinin eleman sayýsý:");
		int elemansayýsý=klavye.nextInt();
		dizi=new int[elemansayýsý];
		for ( int i : dizi) {
			System.out.print(i+" ");
		}
	}
}
