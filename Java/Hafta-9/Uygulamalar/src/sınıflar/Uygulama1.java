package s�n�flar;

import java.awt.Color;

public class Uygulama1 {

	public static void main(String[] args) {
		Top top1=new Top();
		top1.elastikiyet=10;
		top1.�ap=3.45;
		top1.hammadde="Deri";
		top1.renk=Color.red;
		System.out.println("Top1 nesnesinin elastikiyet �zelli�i:"+top1.elastikiyet);
		System.out.println("Top1 nesnesinin �ap �zelli�i:"+top1.�ap);
		System.out.println("Top1 nesnesinin hammadde �zelli�i:"+top1.hammadde);
		System.out.println("Top1 nesnesinin renk �zelli�i:"+top1.renk);
		top1.z�pla();
		top1.yuvarlan();
	}
}
