
public class AnaProgram4 {

	public static void main(String[] args) {
		CepTelefonu s3=new CepTelefonu();
		s3.müzikÇal();//Erken Baðlama (Static-Early Binding)
		//s3 nesnesi CepTelefonu sýnýfýndan oluþturulduðu için ve CepTelefonu sýnýfýnda
		//bir tane müzikÇal metodu olduðu için yani üst sýnýf Telefon sýnýfýnda
		//ayný isimde metod bulunmadýðý için hangi metodu çalýþtýracaðý baþtan 
		//bellidir, dolayýsýyla buna erken baðlama denir.
		
		Telefon s2=new CepTelefonu();
		s2.aramaYap();//Geç Baðlama (Dynamic-Late Binding)
		
		//s2 nesnesinin hangi aramaYap metodunu kullanacaðý kod compile edilirken
		//belli deðildir çünkü s2 nesnesi telefon sýnýfýndan oluþturulmuþ ancak
		//CepTelefonu sýnýfýna referans gösterilmiþ bir nesnedir. aramaYap
		//metodu üst sýnýfta da alt sýnýfta da bulunmaktadýr.Dolayýsýyla hangi
		//aramaYap metodunun çalýþacaðý kod çalýþýrken belirlenir, bu tür baðlamaya
		//geç baðlama denir.
	}
}