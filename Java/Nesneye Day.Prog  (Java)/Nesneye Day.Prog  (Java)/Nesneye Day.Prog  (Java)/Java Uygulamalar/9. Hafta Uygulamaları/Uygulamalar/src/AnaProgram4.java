import java.awt.Color;

public class AnaProgram4 {
	
	public static void main(String[] args) {
		Top top1=new Top();
		System.out.println("Olu�turuldu�undaki �zellikler:");
		System.out.println("Top1 in �ap�:"+top1.�ap);
		System.out.println("Top1 in rengi"+top1.renk);
		System.out.println("Top1 in elastikiyeti:"+top1.elastikiyet);
		System.out.println("Top1 in hammaddesi:"+top1.hammadde);
		top1.�ap=6.78;
		top1.renk=Color.black;
		System.out.println("Yeni �zellikler:");
		System.out.println("Top1 in �ap�:"+top1.�ap);
		System.out.println("Top1 in rengi"+top1.renk);
		System.out.println("Top1 in elastikiyeti:"+top1.elastikiyet);
		System.out.println("Top1 in hammaddesi:"+top1.hammadde);
	}
}
