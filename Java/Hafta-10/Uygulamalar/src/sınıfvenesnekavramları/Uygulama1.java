package s�n�fvenesnekavramlar�;

import java.awt.Color;
import java.util.Scanner;

public class Uygulama1 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Birinci say�y� giriniz:");
		double say�1=klavye.nextDouble();
		System.out.println("�kinci say�y� giriniz:");
		double say�2=klavye.nextDouble();
		System.out.println("Toplama i�in[1],��karma i�in[2],B�lme i�in[3],�arpma i�in[4]");
		int tercih=klavye.nextInt();
		HesapMakinas� hesapmakinas�=new HesapMakinas�("Kare", 12, 20, Color.gray);
		if(tercih==1){
			System.out.println("Sonu�:"+hesapmakinas�.toplamaYap(say�1, say�2));
		}
		else if(tercih==2){
			System.out.println("Sonu�:"+hesapmakinas�.��karmaYap(say�1, say�2));
		}
		else if(tercih==3){
			System.out.println("Sonu�:"+hesapmakinas�.b�lmeYap(say�1, say�2));
		}
		else if(tercih==4){
			System.out.println("Sonu�:"+hesapmakinas�.�arpmaYap(say�1, say�2));
		}
		else{
			System.out.println("Hatal� Giri�....");
		}klavye.close();
	}

}
