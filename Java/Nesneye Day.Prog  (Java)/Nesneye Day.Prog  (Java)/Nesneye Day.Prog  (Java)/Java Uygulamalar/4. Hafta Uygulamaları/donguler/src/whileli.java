import java.util.Scanner;


public class whileli {


	public static void main(String[] args) {
@SuppressWarnings("resource")
Scanner klavye=new Scanner(System.in);
System.out.println("bir sayý giriniz : ");
int sayi=klavye.nextInt();
while(sayi!=0){
	System.out.println("sayýnýn karesi : "+Math.pow(sayi, 2));
	System.out.println("bir sayý giriniz : ");
 sayi=klavye.nextInt();
}
System.out.println("program 0 girildiðinden durmuþtur.miþeyn komleyt :D");
	}

}
