package kal�t�m;

import java.awt.Color;

public class FutbolTopu extends Top{
	
	double a��rl�k;

	public FutbolTopu(Color r, double �, String h) {
		super(r, �, h);
	}
	public void golOl(){
		System.out.println("Futbol topu a�larla bulu�tu...");
	}	
	public void z�pla(){//Method Overriding
		System.out.println("Futbol topu z�plad�....");
	}
}
