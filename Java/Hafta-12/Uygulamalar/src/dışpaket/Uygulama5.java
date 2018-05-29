package dýþpaket;

import eriþimbelirleyiciler.Asker;

public class Uygulama5 {

	public static void main(String[] args) {
		Asker asker=new Asker();
		asker.setMaaþ(3000);//Setter metot ile private deðiþken deðiþtirildi.
		System.out.println("Askerin maaþý:"+asker.getMaaþ());
		//getMaaþ metodu ile private olan maaþ deðeri çekilerek konsola
		//yazdýrýldý.
	}
}
