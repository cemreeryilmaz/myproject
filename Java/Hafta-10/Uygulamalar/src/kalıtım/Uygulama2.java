package kal�t�m;

import java.awt.Color;

public class Uygulama2 {

	public static void main(String[] args) {
		FutbolTopu futboltopu=new FutbolTopu(Color.white, 12.34, "Deri");
		System.out.println("Renk �zelli�i:"+futboltopu.renk);
		System.out.println("�ap �zelli�i:"+futboltopu.�ap);
		System.out.println("Hammadde �zelli�i:"+futboltopu.hammadde);
		System.out.println("A��rl�k �zelli�i:"+futboltopu.a��rl�k);
		futboltopu.golOl();
		futboltopu.z�pla();
		futboltopu.yuvarlan();
		BasketTopu baskettopu=new BasketTopu(Color.red, 13.5, "Plastik");
		System.out.println("---------Basket topu nesnesi i�in �zellikler--------");
		System.out.println("Renk �zelli�i:"+baskettopu.renk);
		System.out.println("�ap �zelli�i:"+baskettopu.�ap);
		System.out.println("Hammadde �zelli�i:"+baskettopu.hammadde);
		System.out.println("Hava bas�nc� �zelli�i:"+baskettopu.havabas�nc�);
		baskettopu.basketOl();
		baskettopu.z�pla();
		baskettopu.yuvarlan();
	}
}
