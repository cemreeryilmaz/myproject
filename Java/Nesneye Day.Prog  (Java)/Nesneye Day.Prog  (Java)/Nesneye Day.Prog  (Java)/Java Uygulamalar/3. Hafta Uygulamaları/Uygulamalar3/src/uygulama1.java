import java.util.Scanner;
public class uygulama1 {
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		int bakiye=2000;
		int limit=1500;
		System.out.println("�u anki bakiyeniz:"+bakiye);
		System.out.println("�ekmek istedi�iniz miktar� giriniz:");
		int �ekilecekmiktar=klavye.nextInt();
		if(�ekilecekmiktar<=bakiye&&�ekilecekmiktar<=limit){			
			bakiye-=�ekilecekmiktar;
			System.out.println("Yeni bakiye:"+bakiye);
		}
		else{
			if(bakiye<�ekilecekmiktar){
				System.out.println("Yetersiz Bakiye...");
			}
			else{
				System.out.println("Limiti a�amazs�n�z");
			}
		}

	}

}
