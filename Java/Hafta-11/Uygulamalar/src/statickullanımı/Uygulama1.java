package statickullan�m�;

public class Uygulama1 {

	public static void main(String[] args) {
		�al��an �al��an1=new �al��an(1234, "Ahmet", "Y�lmaz", 2000);
		�al��an �al��an2=new �al��an(1235, "Mehmet", "Y�lmaz", 2000);
		System.out.println("�al��an1 nesnesinin kurum �zelli�i:"+�al��an.kurum);
		System.out.println("�al��an2 nesnesinin kurum �zelli�i:"+�al��an.kurum);
		�al��an.kurum="�stanbul �niversitesi";
		System.out.println("De�i�iklikten sonra--------------------");
		System.out.println("�al��an1 nesnesinin kurum �zelli�i:"+�al��an.kurum);
		System.out.println("�al��an2 nesnesinin kurum �zelli�i:"+�al��an.kurum);
	}
}
