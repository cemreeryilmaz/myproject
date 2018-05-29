import java.util.Scanner;

public class Uygulama8 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Bir kelime giriniz:");
		String kelime=klavye.next();
		if(kelime.indexOf("a")!=-1){
			System.out.println(kelime.indexOf("a")+1+".sýrada");
		}
		else{
			System.out.println("a harfi bulunmamaktadýr.");
		}

	}

}
