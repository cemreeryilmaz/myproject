import Çalýþanlar.Müdür;
import Çalýþanlar.Çalýþan;
import Çalýþanlar.Öðretmen;


public class AnaProgram4 {

	public static void main(String[] args) {
		Çalýþan[]çalýþanlar=new Çalýþan[3];
		çalýþanlar[0]=new Çalýþan(1234,"ahmet","beyaz",6700);
		çalýþanlar[1]=new Müdür(1235,"bahadýr","kara",4500);
		çalýþanlar[2]=new Öðretmen(1236,"yavuz","kaya",3400);
		//konuþtur(çalýþanlar[2]);
		//konuþtur(çalýþanlar);
		Çalýþan[] yenidizi=maaþArttýr(çalýþanlar);
		System.out.println("1.nesnenin maaþý:"+yenidizi[0].maaþ);
		System.out.println("2.nesnenin maaþý:"+yenidizi[1].maaþ);
		System.out.println("3.nesnenin maaþý:"+yenidizi[2].maaþ);
	}
	public static void konuþtur(Çalýþan[] nesnedizisi){
		for (int i = 0; i < nesnedizisi.length; i++) {
			nesnedizisi[i].konuþ();
		}
		}
	public static Çalýþan[] maaþArttýr(Çalýþan[] nesnedizisi){
		for (int i = 0; i < nesnedizisi.length; i++) {
			nesnedizisi[i].maaþ+=500;
		}
		return nesnedizisi;
	}
}
