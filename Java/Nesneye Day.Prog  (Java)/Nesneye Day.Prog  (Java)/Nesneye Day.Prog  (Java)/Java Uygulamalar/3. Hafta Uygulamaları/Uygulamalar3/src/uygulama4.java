import java.util.Scanner;

public class uygulama4 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Notu giriniz:");
		int not=klavye.nextInt();
		if(not<0)
		{
			System.out.println("Hatalý Giriþ...");			
		}
		else{
			if(not<=39){
			System.out.println("FF");
		}
		else if(not<=44){
			System.out.println("DD");
		}
		else if(not<=49){
			System.out.println("DC");
		}
		else if(not<=64){
			System.out.println("CC");
		}
		else if(not<=74){
			System.out.println("CB");
		}
		else if(not<=84){
			System.out.println("BB");
		}
		else if(not<=90){
			System.out.println("BA");
		}
		else if(not<=100){
			System.out.println("AA");
		}
		else
		{
			System.out.println("Hatalý Giriþ...");
		}
		}
		
	}

}
