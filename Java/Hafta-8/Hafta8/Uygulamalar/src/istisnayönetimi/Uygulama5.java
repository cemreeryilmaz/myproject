package istisnay�netimi;

public class Uygulama5 {

	public static void main(String[] args) {
		int say�=10;
		try {
			System.out.println("sonu�:"+say�/0);
		} catch (ArithmeticException e) {
			System.out.println("S�f�ra b�l�m tan�ms�zd�r.");
		}finally{
			System.out.println("Finally blo�u �al��t�.");
		}
	}
}
