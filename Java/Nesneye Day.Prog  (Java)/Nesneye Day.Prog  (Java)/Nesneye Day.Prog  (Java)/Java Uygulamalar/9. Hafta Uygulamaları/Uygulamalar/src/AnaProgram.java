import java.awt.Color;

public class AnaProgram {
	
	public static void main(String[] args) {
		Top top1=new Top();
		System.out.println("Nesne ilk oluþturulduðundaki özellikler:");
		System.out.println("Nesnenin elastikiyeti:"+top1.elastikiyet);
		System.out.println("Nesnenin rengi:"+top1.renk);
		System.out.println("Nesnenin çapý:"+top1.çap);
		System.out.println("Nesnenin hammaddesi:"+top1.hammadde);
		System.out.println("------------------------------");
		top1.elastikiyet=10;
		top1.hammadde="Plastik";
		top1.renk=Color.red;
		top1.çap=12.3;
		System.out.println("Nesnenin özellikleri belirlendikten sonra:");
		System.out.println("Nesnenin elastikiyeti:"+top1.elastikiyet);
		System.out.println("Nesnenin rengi:"+top1.renk);
		System.out.println("Nesnenin çapý:"+top1.çap);
		System.out.println("Nesnenin hammaddesi:"+top1.hammadde);		
	}
}
