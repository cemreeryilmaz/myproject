package statickullan�m�;

public class Uygulama5 {

	public static void main(String[] args) {
		�al��an �al��an=new �al��an(1234, "Ahmet", "Vatan", 3000);
		�al��an.�al��();//Erken ba�lama(Static binding-Early binding)
		�al��an �al��an2=new ��retmen(1235, "Hasan", "Kurt", 4000);
		�al��an2.�al��();//Ge� ba�lama(Dynamic binding-Late binding)
		//�al��an nesnesinin hangi �al�� metodunu kullanaca�� kod compile edildi�inde
		//bellidir, buna erken ba�lama denir.
		//�al��an2 nesnesi ��retmen s�n�f�n� referans g�sterdi�i i�in �al�� metodunun
		//�al��an s�n�f�ndan m� yoksa ��retmen s�n�f�ndan m� kullanaca�� belli de�ildir.
		//Belirlenmesi i�in kodun �al��mas� gerekir. �al��ma an�nda belirlendi�i i�in
		//buna ge� ba�lama denir.
	}
}
