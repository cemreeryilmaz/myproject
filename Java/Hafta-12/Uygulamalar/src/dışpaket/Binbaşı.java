package dýþpaket;

import eriþimbelirleyiciler.Asker;

public class Binbaþý extends Asker {
	
	public void bilgiVer(){
		System.out.println("Adým: "+this.adsoyad+" Sýnýfým:"+this.sýnýf);
		//Paket dýþýndan kalýtým ile eriþimde sadece public ve protected
		//özellikler eriþilebilir durumdadýr, private veya default olan
		//özelliklere eriþim yoktur.
	}
}
