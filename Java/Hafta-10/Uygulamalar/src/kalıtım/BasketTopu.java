package kal�t�m;

import java.awt.Color;

public class BasketTopu extends Top{

	double havabas�nc�;
	
	public BasketTopu(Color r, double �, String h) {
		super(r, �, h);
	}
	public void basketOl(){
	System.out.println("Basket topu potaya girdi....");	
	}
	public void z�pla(){//Method Overriding
		System.out.println("Basket topu z�plad�....");
	}
}
