
public class Uygulama3 {

	public static void main(String[] args) {
		String adsoyad="Fazýl Hüsnü Daðlarca";
		try {
			String soyad=adsoyad.substring(12,21);
		System.out.println("Soyadý:"+soyad);
		} catch (StringIndexOutOfBoundsException e) {
			System.out.println(e.getMessage());
		}
	}
}
