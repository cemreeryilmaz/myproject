import java.util.Scanner;
public class uygulama5 {
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		System.out.println("Kilonuzu giriniz(Kg):");
		double kilo=klavye.nextDouble();
		System.out.println("Boyunuzu giriniz(M):");
		double boy=klavye.nextDouble();
		double bmi=kilo/Math.pow(boy, 2);
		if(bmi<=18.5){
			System.out.println("Zayýf");
		}
		else if(bmi<=24.99){
			System.out.println("Normal");
		}
		else if(bmi<=29.99){
			System.out.println("Kilolu");
		}
		else
		{
			System.out.println("Obez");
		}

	}

}
