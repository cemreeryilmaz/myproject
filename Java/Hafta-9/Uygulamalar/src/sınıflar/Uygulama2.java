package sýnýflar;

import java.awt.Color;

public class Uygulama2 {

	public static void main(String[] args) {
		Top top1=new Top(10,5.8,Color.yellow,"Deri");
		Top top2=new Top(20,7.98,Color.blue,"Sünger");
		System.out.println("Top1 nesnesinin elastikiyet özelliði:"+top1.elastikiyet);
		System.out.println("Top1 nesnesinin çap özelliði:"+top1.çap);
		System.out.println("Top1 nesnesinin renk özelliði:"+top1.renk);
		System.out.println("Top1 nesnesinin hammadde özelliði:"+top1.hammadde);
		//-----------------------------------------------------------------------
		System.out.println("Top2 nesnesinin elastikiyet özelliði:"+top2.elastikiyet);
		System.out.println("Top2 nesnesinin çap özelliði:"+top2.çap);
		System.out.println("Top2 nesnesinin renk özelliði:"+top2.renk);
		System.out.println("Top2 nesnesinin hammadde özelliði:"+top2.hammadde);
	}
}
