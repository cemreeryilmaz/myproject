package d��paket;

import eri�imbelirleyiciler.Asker;

public class Binba�� extends Asker {
	
	public void bilgiVer(){
		System.out.println("Ad�m: "+this.adsoyad+" S�n�f�m:"+this.s�n�f);
		//Paket d���ndan kal�t�m ile eri�imde sadece public ve protected
		//�zellikler eri�ilebilir durumdad�r, private veya default olan
		//�zelliklere eri�im yoktur.
	}
}
