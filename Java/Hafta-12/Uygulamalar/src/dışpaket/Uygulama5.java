package d��paket;

import eri�imbelirleyiciler.Asker;

public class Uygulama5 {

	public static void main(String[] args) {
		Asker asker=new Asker();
		asker.setMaa�(3000);//Setter metot ile private de�i�ken de�i�tirildi.
		System.out.println("Askerin maa��:"+asker.getMaa�());
		//getMaa� metodu ile private olan maa� de�eri �ekilerek konsola
		//yazd�r�ld�.
	}
}
