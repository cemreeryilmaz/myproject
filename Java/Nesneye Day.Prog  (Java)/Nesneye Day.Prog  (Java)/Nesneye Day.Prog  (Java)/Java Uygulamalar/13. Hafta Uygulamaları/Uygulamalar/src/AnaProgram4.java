import �al��anlar.M�d�r;
import �al��anlar.�al��an;
import �al��anlar.��retmen;


public class AnaProgram4 {

	public static void main(String[] args) {
		�al��an[]�al��anlar=new �al��an[3];
		�al��anlar[0]=new �al��an(1234,"ahmet","beyaz",6700);
		�al��anlar[1]=new M�d�r(1235,"bahad�r","kara",4500);
		�al��anlar[2]=new ��retmen(1236,"yavuz","kaya",3400);
		//konu�tur(�al��anlar[2]);
		//konu�tur(�al��anlar);
		�al��an[] yenidizi=maa�Artt�r(�al��anlar);
		System.out.println("1.nesnenin maa��:"+yenidizi[0].maa�);
		System.out.println("2.nesnenin maa��:"+yenidizi[1].maa�);
		System.out.println("3.nesnenin maa��:"+yenidizi[2].maa�);
	}
	public static void konu�tur(�al��an[] nesnedizisi){
		for (int i = 0; i < nesnedizisi.length; i++) {
			nesnedizisi[i].konu�();
		}
		}
	public static �al��an[] maa�Artt�r(�al��an[] nesnedizisi){
		for (int i = 0; i < nesnedizisi.length; i++) {
			nesnedizisi[i].maa�+=500;
		}
		return nesnedizisi;
	}
}
