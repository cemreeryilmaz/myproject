import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Kısa kenarı giriniz:");
		int kısakenar=klavye.nextInt();
		System.out.println("Uzun kenarı giriniz:");
		int uzunkenar=klavye.nextInt();
		System.out.println("Alanı:"+alanVeÇevreHesapla(uzunkenar,kısakenar)[0]);
		System.out.println("Çevresi:"+alanVeÇevreHesapla(uzunkenar,kısakenar)[1]);
		
	}
	public static int[] alanVeÇevreHesapla(int kk,int uk){
		int[]dizi=new int[2];
		dizi[0]=kk*uk;
		dizi[1]=2*(uk+kk);
		return dizi;
	}

}
