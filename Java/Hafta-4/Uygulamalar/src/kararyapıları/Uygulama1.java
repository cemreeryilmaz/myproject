package kararyap�lar�;

import java.util.Scanner;

public class Uygulama1 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("0 ile 100 aras� bir say� giriniz:");
		int say�=klavye.nextInt();
		if(say�>=0&&say�<=100){
			if(say�<=29){
				System.out.println("FF");
			}else if(say�<=39){
				System.out.println("DD");
			}else if(say�<=49){
				System.out.println("DC");
			}else if(say�<=60){
				System.out.println("CC");
			}else if(say�<=70){
				System.out.println("CB");
			}else if(say�<=80){
				System.out.println("BB");
			}else if(say�<=89){
				System.out.println("BA");
			}else if(say�<=100){
				System.out.println("AA");
			}
		}
		else{
			System.out.println("Hatal� giri�");
		}
		klavye.close();
	}
}
