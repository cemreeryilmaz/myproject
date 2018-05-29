package dýþpaket;

import eriþimbelirleyiciler.Asker;

public class Uygulama4 {

	public static void main(String[] args) {
		Asker asker=new Asker();
		//asker nesnesi sadece adsoyad özelliðine ulaþabildi,
		//çünkü adsoyad özelliðinin eriþim belirleyicisi
		//public.
		Binbaþý binbaþý=new Binbaþý();
		binbaþý.adsoyad="Mehmet Yýlmaz";
		binbaþý.bilgiVer();
	}
}
