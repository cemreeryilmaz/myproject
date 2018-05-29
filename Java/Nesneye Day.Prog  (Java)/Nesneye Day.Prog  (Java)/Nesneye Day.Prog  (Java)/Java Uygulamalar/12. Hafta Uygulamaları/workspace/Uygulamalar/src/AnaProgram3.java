
public class AnaProgram3 {

	public static void main(String[] args) {
		CepTelefonu s5=new CepTelefonu();
		s5.müzikÇal();
		Telefon evtelefonu=s5;
		evtelefonu.aramaYap();//Yukarý Çevrim (UpCasting)
		
		Telefon takoz=new CepTelefonu();
		takoz.aramaYap();
		CepTelefonu iphone5s=(CepTelefonu) takoz;
		iphone5s.müzikÇal();//Aþaðý Çevrim (DownCasting)		

	}
}
