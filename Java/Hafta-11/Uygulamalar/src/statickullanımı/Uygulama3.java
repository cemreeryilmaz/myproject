package statickullan�m�;

public class Uygulama3 {

	public static void main(String[] args) {
		�al��an �al��an=new ��retmen(1234, "Ahmet", "Y�lmaz", 2000);
		System.out.println("�evrimden �nce sigortano:"+�al��an.sigortano);
		System.out.println("�evrimden �nce ad:"+�al��an.ad);
		System.out.println("�evrimden �nce soyad:"+�al��an.soyad);
		System.out.println("�evrimden �nce maa�:"+�al��an.maa�);
		��retmen ��retmen=(��retmen)�al��an;
		System.out.println("A�a�� �evrim yap�ld�ktan sonra:");
		System.out.println("�evrimden sonra sigortano:"+��retmen.sigortano);
		System.out.println("�evrimden sonra ad:"+��retmen.ad);
		System.out.println("�evrimden sonra soyad:"+��retmen.soyad);
		System.out.println("�evrimden sonra maa�:"+��retmen.maa�);
		��retmen.bran�="Tarih";
		System.out.println("�evrimden sonra bran�:"+��retmen.bran�);
	}
}
