package statickullan�m�;

public class Uygulama4 {

	public static void main(String[] args) {
		��retmen ��retmen=new ��retmen(1235, "Ay�e", "Kaya", 2500);
		System.out.println("Yukar� �evrimden �nce ad�:"+��retmen.ad);
		System.out.println("Yukar� �evrimden �nce soyad�:"+��retmen.soyad);
		System.out.println("Yukar� �evrimden �nce maa��:"+��retmen.maa�);
		System.out.println("Yukar� �evrimden �nce sigortano:"+��retmen.sigortano);
		��retmen.bran�="Beden E�itimi";
		System.out.println("Yukar� �evrimden �nce bran��:"+��retmen.bran�);
		�al��an �al��an=��retmen;
		//Yukar� �evrimde casting yap�lmaz, referans g�sterme i�lemine gerek yoktur.
		//��nk� alt s�n�ftan �st s�n�fa �evrilirken sadece bir ihtimal vard�r yani
		//sadece bir tane �st s�n�f vard�r. Ancak a�a�� �evrimde �st s�n�ftan olu�turulan
		//nesnenin hangi alt s�n�fa �evrilece�i belirsiz oldu�u i�in referans g�sterme
		//i�lemi zorunludur.
		System.out.println("Yukar� �evrimden sonra ad�:"+�al��an.ad);
		System.out.println("Yukar� �evrimden sonra soyad�:"+�al��an.soyad);
		System.out.println("Yukar� �evrimden sonra maa��:"+�al��an.maa�);
		System.out.println("Yukar� �evrimden sonra sigortano:"+�al��an.sigortano);
		//�al��an.bran� eri�ilemez ��nk� yukar� �evrimle nesne �al��an nesnesi oldu.
	}
}
