import java.util.Scanner;


public class whileli {


	public static void main(String[] args) {
@SuppressWarnings("resource")
Scanner klavye=new Scanner(System.in);
System.out.println("bir say� giriniz : ");
int sayi=klavye.nextInt();
while(sayi!=0){
	System.out.println("say�n�n karesi : "+Math.pow(sayi, 2));
	System.out.println("bir say� giriniz : ");
 sayi=klavye.nextInt();
}
System.out.println("program 0 girildi�inden durmu�tur.mi�eyn komleyt :D");
	}

}
