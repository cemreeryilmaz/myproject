import �al��anlar.M�d�r;
import �al��anlar.�al��an;
import �al��anlar.��retmen;


public class AnaProgram3 {

	public static void main(String[] args) {
		�al��an[]�al��anlar=new �al��an[3];
		�al��anlar[0]=new �al��an(1234,"ahmet","beyaz",6700);
		�al��anlar[1]=new M�d�r(1235,"bahad�r","kara",4500);
		�al��anlar[2]=new ��retmen(1236,"yavuz","kaya",3400);
		/*System.out.println("1.nesnenin ad�:"+�al��anlar[0].ad);
		System.out.println("2.nesnenin ad�:"+�al��anlar[1].ad);
		System.out.println("3.nesnenin ad�:"+�al��anlar[2].ad);*/
		for (int i = 0; i < �al��anlar.length; i++) {
			System.out.println((i+1)+".nci nesnenin ad�:"+�al��anlar[i].ad);
		}
	}
}
