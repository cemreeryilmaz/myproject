package Çalýþanlar;

public class Müdür extends Çalýþan{
	
	public void çalýþ(){//Method Overriding(metot ezme)
		System.out.println("Müdür idari iþleri yerine getirdi");
	}
	public void konuþ(){
		System.out.println("Merhaba ben müdür");
	}
	//Çalýþan sýnýfýnýn içinde bulunan konuþ metodu final
	//olarak tanýmlandýðý için alt sýnýfta tekrardan override
	//edilemiyor.
	//Overriding (ezme-üzerinden geçme-iptal etme)
}
