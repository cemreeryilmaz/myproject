package sýnýflar;

import java.awt.Color;

public class Uygulama3 {

	public static void main(String[] args) {
		Top top1=new Top();
		Top top2=new Top(15.3,Color.black);
		Top top3=new Top(3,6.78,Color.gray);
		Top top4=new Top(10,4.67,Color.green,"Deri");
		System.out.println("Top1 nesnesinin elastikiyet özelliði:"+top1.elastikiyet);
		System.out.println("Top1 nesnesinin çapý:"+top1.çap);
		System.out.println("Top1 nesnesinin rengi:"+top1.renk);
		System.out.println("Top1 nesnesinin hammaddesi:"+top1.hammadde);
		//__________________________________________________________________
		System.out.println("Top2 nesnesinin elastikiyet özelliði:"+top2.elastikiyet);
		System.out.println("Top2 nesnesinin çapý:"+top2.çap);
		System.out.println("Top2 nesnesinin rengi:"+top2.renk);
		System.out.println("Top2 nesnesinin hammaddesi:"+top2.hammadde);
		//__________________________________________________________________
		System.out.println("Top3 nesnesinin elastikiyet özelliði:"+top3.elastikiyet);
		System.out.println("Top3 nesnesinin çapý:"+top3.çap);
		System.out.println("Top3 nesnesinin rengi:"+top3.renk);
		System.out.println("Top3 nesnesinin hammaddesi:"+top3.hammadde);
		//__________________________________________________________________
		System.out.println("Top4 nesnesinin elastikiyet özelliði:"+top4.elastikiyet);
		System.out.println("Top4 nesnesinin çapý:"+top4.çap);
		System.out.println("Top4 nesnesinin rengi:"+top4.renk);
		System.out.println("Top4 nesnesinin hammaddesi:"+top4.hammadde);
	}
}
