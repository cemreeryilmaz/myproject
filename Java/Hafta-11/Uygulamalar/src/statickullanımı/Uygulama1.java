package statickullanýmý;

public class Uygulama1 {

	public static void main(String[] args) {
		Çalýþan çalýþan1=new Çalýþan(1234, "Ahmet", "Yýlmaz", 2000);
		Çalýþan çalýþan2=new Çalýþan(1235, "Mehmet", "Yýlmaz", 2000);
		System.out.println("Çalýþan1 nesnesinin kurum özelliði:"+Çalýþan.kurum);
		System.out.println("Çalýþan2 nesnesinin kurum özelliði:"+Çalýþan.kurum);
		Çalýþan.kurum="Ýstanbul Üniversitesi";
		System.out.println("Deðiþiklikten sonra--------------------");
		System.out.println("Çalýþan1 nesnesinin kurum özelliði:"+Çalýþan.kurum);
		System.out.println("Çalýþan2 nesnesinin kurum özelliði:"+Çalýþan.kurum);
	}
}
