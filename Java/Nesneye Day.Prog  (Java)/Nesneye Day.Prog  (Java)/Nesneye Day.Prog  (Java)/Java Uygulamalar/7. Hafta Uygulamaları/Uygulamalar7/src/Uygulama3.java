
public class Uygulama3 {

	public static void main(String[] args) {
		String adsoyad="Faz�l H�sn� Da�larca";
		try {
			String soyad=adsoyad.substring(12,21);
		System.out.println("Soyad�:"+soyad);
		} catch (StringIndexOutOfBoundsException e) {
			System.out.println(e.getMessage());
		}
	}
}
