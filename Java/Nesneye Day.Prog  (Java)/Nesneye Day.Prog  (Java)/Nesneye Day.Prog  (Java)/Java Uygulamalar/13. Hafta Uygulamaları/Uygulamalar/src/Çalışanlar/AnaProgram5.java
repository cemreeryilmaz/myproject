package Çalýþanlar;

public class AnaProgram5 {
	
	public static void main(String[] args) {
		Çalýþan çalýþan1=new Çalýþan(12345,"ahmet","kara",3450);
		System.out.println(çalýþan1.getSoyad());
		çalýþan1.setSoyad("beyaz");
		System.out.println(çalýþan1.getSoyad());

	}

}
