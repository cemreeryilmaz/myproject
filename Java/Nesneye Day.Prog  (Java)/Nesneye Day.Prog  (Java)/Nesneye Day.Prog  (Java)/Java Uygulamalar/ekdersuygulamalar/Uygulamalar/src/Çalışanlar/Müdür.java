package �al��anlar;

public class M�d�r extends �al��an{
	
	public void �al��(){//Method Overriding(metot ezme)
		System.out.println("M�d�r idari i�leri yerine getirdi");
	}
	public void konu�(){
		System.out.println("Merhaba ben m�d�r");
	}
	//�al��an s�n�f�n�n i�inde bulunan konu� metodu final
	//olarak tan�mland��� i�in alt s�n�fta tekrardan override
	//edilemiyor.
	//Overriding (ezme-�zerinden ge�me-iptal etme)
}
