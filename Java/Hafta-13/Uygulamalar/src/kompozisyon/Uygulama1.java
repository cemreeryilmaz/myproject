package kompozisyon;

public class Uygulama1 {

	public static void main(String[] args) {
		Çalýþan çalýþan1=new Çalýþan();
		/*çalýþan1.adres.binano=12;
		çalýþan1.adres.daireno=34;
		çalýþan1.adres.caddeadý="Halkalý Cad.";
		çalýþan1.adres.sokakadý="Gül sokak";*/
		çalýþan1.adresBelirle("Gül sokak", "Halkalý Cad.", 2, 3);
		çalýþan1.adres.bilgiVer();
		
	}

}
