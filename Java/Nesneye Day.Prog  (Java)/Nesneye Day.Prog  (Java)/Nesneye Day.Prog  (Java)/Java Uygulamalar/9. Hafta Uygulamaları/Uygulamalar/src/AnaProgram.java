import java.awt.Color;

public class AnaProgram {
	
	public static void main(String[] args) {
		Top top1=new Top();
		System.out.println("Nesne ilk olu�turuldu�undaki �zellikler:");
		System.out.println("Nesnenin elastikiyeti:"+top1.elastikiyet);
		System.out.println("Nesnenin rengi:"+top1.renk);
		System.out.println("Nesnenin �ap�:"+top1.�ap);
		System.out.println("Nesnenin hammaddesi:"+top1.hammadde);
		System.out.println("------------------------------");
		top1.elastikiyet=10;
		top1.hammadde="Plastik";
		top1.renk=Color.red;
		top1.�ap=12.3;
		System.out.println("Nesnenin �zellikleri belirlendikten sonra:");
		System.out.println("Nesnenin elastikiyeti:"+top1.elastikiyet);
		System.out.println("Nesnenin rengi:"+top1.renk);
		System.out.println("Nesnenin �ap�:"+top1.�ap);
		System.out.println("Nesnenin hammaddesi:"+top1.hammadde);		
	}
}
