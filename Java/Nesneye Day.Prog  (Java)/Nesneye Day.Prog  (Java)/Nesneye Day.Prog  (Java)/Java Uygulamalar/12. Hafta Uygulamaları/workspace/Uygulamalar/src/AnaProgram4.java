
public class AnaProgram4 {

	public static void main(String[] args) {
		CepTelefonu s3=new CepTelefonu();
		s3.m�zik�al();//Erken Ba�lama (Static-Early Binding)
		//s3 nesnesi CepTelefonu s�n�f�ndan olu�turuldu�u i�in ve CepTelefonu s�n�f�nda
		//bir tane m�zik�al metodu oldu�u i�in yani �st s�n�f Telefon s�n�f�nda
		//ayn� isimde metod bulunmad��� i�in hangi metodu �al��t�raca�� ba�tan 
		//bellidir, dolay�s�yla buna erken ba�lama denir.
		
		Telefon s2=new CepTelefonu();
		s2.aramaYap();//Ge� Ba�lama (Dynamic-Late Binding)
		
		//s2 nesnesinin hangi aramaYap metodunu kullanaca�� kod compile edilirken
		//belli de�ildir ��nk� s2 nesnesi telefon s�n�f�ndan olu�turulmu� ancak
		//CepTelefonu s�n�f�na referans g�sterilmi� bir nesnedir. aramaYap
		//metodu �st s�n�fta da alt s�n�fta da bulunmaktad�r.Dolay�s�yla hangi
		//aramaYap metodunun �al��aca�� kod �al���rken belirlenir, bu t�r ba�lamaya
		//ge� ba�lama denir.
	}
}