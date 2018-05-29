package kalýtým;

import java.awt.Color;

public class Uygulama2 {

	public static void main(String[] args) {
		FutbolTopu futboltopu=new FutbolTopu(Color.white, 12.34, "Deri");
		System.out.println("Renk özelliði:"+futboltopu.renk);
		System.out.println("Çap özelliði:"+futboltopu.çap);
		System.out.println("Hammadde özelliði:"+futboltopu.hammadde);
		System.out.println("Aðýrlýk özelliði:"+futboltopu.aðýrlýk);
		futboltopu.golOl();
		futboltopu.zýpla();
		futboltopu.yuvarlan();
		BasketTopu baskettopu=new BasketTopu(Color.red, 13.5, "Plastik");
		System.out.println("---------Basket topu nesnesi için özellikler--------");
		System.out.println("Renk özelliði:"+baskettopu.renk);
		System.out.println("Çap özelliði:"+baskettopu.çap);
		System.out.println("Hammadde özelliði:"+baskettopu.hammadde);
		System.out.println("Hava basýncý özelliði:"+baskettopu.havabasýncý);
		baskettopu.basketOl();
		baskettopu.zýpla();
		baskettopu.yuvarlan();
	}
}
