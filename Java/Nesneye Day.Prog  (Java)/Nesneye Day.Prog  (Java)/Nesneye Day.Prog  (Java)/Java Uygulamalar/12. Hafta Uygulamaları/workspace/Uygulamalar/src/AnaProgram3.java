
public class AnaProgram3 {

	public static void main(String[] args) {
		CepTelefonu s5=new CepTelefonu();
		s5.m�zik�al();
		Telefon evtelefonu=s5;
		evtelefonu.aramaYap();//Yukar� �evrim (UpCasting)
		
		Telefon takoz=new CepTelefonu();
		takoz.aramaYap();
		CepTelefonu iphone5s=(CepTelefonu) takoz;
		iphone5s.m�zik�al();//A�a�� �evrim (DownCasting)		

	}
}
