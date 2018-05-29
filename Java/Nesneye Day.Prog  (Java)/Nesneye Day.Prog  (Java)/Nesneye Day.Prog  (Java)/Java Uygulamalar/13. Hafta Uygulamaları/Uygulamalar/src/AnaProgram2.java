import Çalýþanlar.Müdür;


public class AnaProgram2 {

	public static void main(String[] args) {
		Müdür[] müdürler=new Müdür[3];
		müdürler[0]=new Müdür(2345,"ayþe","beyaz",5600);
		//müdürler[1]=new Çalýþan(2346,"hasan","kara",8900);
		//Alt sýnýfýn nesne dizisinin elemanýný üst sýnýf olarak
		//oluþturamayýz.
		müdürler[0].çalýþ(5);
	}
}
