package s�n�flar;

public class Uygulama4 {

	public static void main(String[] args) {
		Zar zar1=new Zar();
		Zar zar2=new Zar();
		int denememiktar�=0;
		int zar1de�eri = 0,zar2de�eri=0;
		while(zar1de�eri!=1||zar2de�eri!=1){
			zar1de�eri=zar1.salla();
			zar2de�eri=zar2.salla();
			denememiktar�++;			
		}
		System.out.println(denememiktar�+". denemede 1-1 geldi");
	}
}
