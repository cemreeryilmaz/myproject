import java.util.Scanner;
public class uygulama1 {
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		int bakiye=2000;
		int limit=1500;
		System.out.println("Şu anki bakiyeniz:"+bakiye);
		System.out.println("Çekmek istediğiniz miktarı giriniz:");
		int çekilecekmiktar=klavye.nextInt();
		if(çekilecekmiktar<=bakiye&&çekilecekmiktar<=limit){			
			bakiye-=çekilecekmiktar;
			System.out.println("Yeni bakiye:"+bakiye);
		}
		else{
			if(bakiye<çekilecekmiktar){
				System.out.println("Yetersiz Bakiye...");
			}
			else{
				System.out.println("Limiti aşamazsınız");
			}
		}

	}

}
