package kararyapıları;

import java.util.Scanner;

public class Uygulama5 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		int bakiye=4000;
		int günlüklimit=1500;
		System.out.println("Çekilecek miktarı giriniz:");
		int çekilecekmiktar=klavye.nextInt();
		if(çekilecekmiktar<=bakiye&&çekilecekmiktar<=günlüklimit){
			bakiye-=çekilecekmiktar;
			System.out.println("Yeni bakiye:"+bakiye);
		}
		else
		{
			if(çekilecekmiktar>bakiye)
				System.out.println("Bakiye Yetersiz.");
			else
				System.out.println("Günlük limit aşılamaz.");
		}
		klavye.close();
	}	
}
