package istisnayönetimi;

public class Uygulama5 {

	public static void main(String[] args) {
		int sayý=10;
		try {
			System.out.println("sonuç:"+sayý/0);
		} catch (ArithmeticException e) {
			System.out.println("Sýfýra bölüm tanýmsýzdýr.");
		}finally{
			System.out.println("Finally bloðu çalýþtý.");
		}
	}
}
