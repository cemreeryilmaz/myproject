import java.awt.Color;
import java.util.Random;
import java.util.Scanner;
public class AnaProgram2 {	
	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		Random rasgele=new Random();
		Top top1=new Top();
		System.out.println("Topun çapýný giriniz:");
		top1.çap=klavye.nextDouble();
		System.out.println("Topun hammaddesinin giriniz:");
		top1.hammadde=klavye.next();
		System.out.println("Topun elaskiyetini giriniz:");
		top1.elastikiyet=klavye.nextInt();
		top1.renk=new Color(rasgele.nextInt(255),rasgele.nextInt(255),rasgele.nextInt(255));
		System.out.println("Nesnenin özellikleri:");
		System.out.println("Nesnenin çapý:"+top1.çap);
		System.out.println("Nesnenin hammaddesi:"+top1.hammadde);
		System.out.println("Nesnenin elastikiyeti:"+top1.elastikiyet);
		System.out.println("Nesnenin rengi:"+top1.renk);
	}
}
