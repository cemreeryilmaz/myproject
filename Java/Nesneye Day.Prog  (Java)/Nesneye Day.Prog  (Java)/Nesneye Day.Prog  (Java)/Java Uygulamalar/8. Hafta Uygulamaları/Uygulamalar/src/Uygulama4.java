import java.util.Scanner;

public class Uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("K�sa kenar� giriniz:");
		int k�sakenar=klavye.nextInt();
		System.out.println("Uzun kenar� giriniz:");
		int uzunkenar=klavye.nextInt();
		System.out.println("Alan�:"+alanVe�evreHesapla(uzunkenar,k�sakenar)[0]);
		System.out.println("�evresi:"+alanVe�evreHesapla(uzunkenar,k�sakenar)[1]);
		
	}
	public static int[] alanVe�evreHesapla(int kk,int uk){
		int[]dizi=new int[2];
		dizi[0]=kk*uk;
		dizi[1]=2*(uk+kk);
		return dizi;
	}

}
