package sýnýflar;

public class Uygulama4 {

	public static void main(String[] args) {
		Zar zar1=new Zar();
		Zar zar2=new Zar();
		int denememiktarý=0;
		int zar1deðeri = 0,zar2deðeri=0;
		while(zar1deðeri!=1||zar2deðeri!=1){
			zar1deðeri=zar1.salla();
			zar2deðeri=zar2.salla();
			denememiktarý++;			
		}
		System.out.println(denememiktarý+". denemede 1-1 geldi");
	}
}
