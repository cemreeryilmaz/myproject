package s�n�flar;

import java.awt.Color;

public class Uygulama2 {

	public static void main(String[] args) {
		Top top1=new Top(10,5.8,Color.yellow,"Deri");
		Top top2=new Top(20,7.98,Color.blue,"S�nger");
		System.out.println("Top1 nesnesinin elastikiyet �zelli�i:"+top1.elastikiyet);
		System.out.println("Top1 nesnesinin �ap �zelli�i:"+top1.�ap);
		System.out.println("Top1 nesnesinin renk �zelli�i:"+top1.renk);
		System.out.println("Top1 nesnesinin hammadde �zelli�i:"+top1.hammadde);
		//-----------------------------------------------------------------------
		System.out.println("Top2 nesnesinin elastikiyet �zelli�i:"+top2.elastikiyet);
		System.out.println("Top2 nesnesinin �ap �zelli�i:"+top2.�ap);
		System.out.println("Top2 nesnesinin renk �zelli�i:"+top2.renk);
		System.out.println("Top2 nesnesinin hammadde �zelli�i:"+top2.hammadde);
	}
}
