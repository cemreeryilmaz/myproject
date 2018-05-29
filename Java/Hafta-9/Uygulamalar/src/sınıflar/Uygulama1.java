package sýnýflar;

import java.awt.Color;

public class Uygulama1 {

	public static void main(String[] args) {
		Top top1=new Top();
		top1.elastikiyet=10;
		top1.çap=3.45;
		top1.hammadde="Deri";
		top1.renk=Color.red;
		System.out.println("Top1 nesnesinin elastikiyet özelliði:"+top1.elastikiyet);
		System.out.println("Top1 nesnesinin çap özelliði:"+top1.çap);
		System.out.println("Top1 nesnesinin hammadde özelliði:"+top1.hammadde);
		System.out.println("Top1 nesnesinin renk özelliði:"+top1.renk);
		top1.zýpla();
		top1.yuvarlan();
	}
}
