import Çalýþanlar.Müdür;
import Çalýþanlar.Çalýþan;
import Çalýþanlar.Öðretmen;


public class AnaProgram3 {

	public static void main(String[] args) {
		Çalýþan[]çalýþanlar=new Çalýþan[3];
		çalýþanlar[0]=new Çalýþan(1234,"ahmet","beyaz",6700);
		çalýþanlar[1]=new Müdür(1235,"bahadýr","kara",4500);
		çalýþanlar[2]=new Öðretmen(1236,"yavuz","kaya",3400);
		/*System.out.println("1.nesnenin adý:"+çalýþanlar[0].ad);
		System.out.println("2.nesnenin adý:"+çalýþanlar[1].ad);
		System.out.println("3.nesnenin adý:"+çalýþanlar[2].ad);*/
		for (int i = 0; i < çalýþanlar.length; i++) {
			System.out.println((i+1)+".nci nesnenin adý:"+çalýþanlar[i].ad);
		}
	}
}
