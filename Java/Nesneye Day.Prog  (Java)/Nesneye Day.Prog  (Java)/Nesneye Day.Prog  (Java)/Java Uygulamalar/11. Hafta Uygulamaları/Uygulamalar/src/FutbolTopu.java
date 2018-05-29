
public class FutbolTopu extends Top{
	
	double aðýrlýk;
	
	public void golOl(){
		
	}
	public void zýpla(){//method overriding(metot ezme-metod iptal etme)
		System.out.println("Futbol topu zýpladý.");
	}
	public void zýpla(int zýplamasayýsý){//method overloading)
		System.out.println("Futbol topu"+zýplamasayýsý+" kere zýpladý.");
	}
}
