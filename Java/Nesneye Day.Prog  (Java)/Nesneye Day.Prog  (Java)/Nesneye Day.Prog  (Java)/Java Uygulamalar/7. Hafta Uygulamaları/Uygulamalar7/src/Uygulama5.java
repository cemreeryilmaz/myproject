import java.util.Scanner;

public class Uygulama5 {

	public static void main(String[] args) {
		int[]dizi = null;
		Scanner klavye=new Scanner(System.in);
		try {
			System.out.println(dizi[0]);
		} catch (Exception e) {
			System.out.println("Dizi bo�");
		}		
		System.out.println("Dizinin eleman say�s�:");
		int elemansay�s�=klavye.nextInt();
		dizi=new int[elemansay�s�];
		for ( int i : dizi) {
			System.out.print(i+" ");
		}
	}
}
