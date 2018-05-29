package kararyapıları;

import java.util.Scanner;

public class Uygulama1 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("0 ile 100 arası bir sayı giriniz:");
		int sayı=klavye.nextInt();
		if(sayı>=0&&sayı<=100){
			if(sayı<=29){
				System.out.println("FF");
			}else if(sayı<=39){
				System.out.println("DD");
			}else if(sayı<=49){
				System.out.println("DC");
			}else if(sayı<=60){
				System.out.println("CC");
			}else if(sayı<=70){
				System.out.println("CB");
			}else if(sayı<=80){
				System.out.println("BB");
			}else if(sayı<=89){
				System.out.println("BA");
			}else if(sayı<=100){
				System.out.println("AA");
			}
		}
		else{
			System.out.println("Hatalı giriş");
		}
		klavye.close();
	}
}
