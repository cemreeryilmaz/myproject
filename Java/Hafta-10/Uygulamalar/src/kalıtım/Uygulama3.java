package kal�t�m;

import �okbi�imlilik.Memur;
import �okbi�imlilik.M�d�r;
import �okbi�imlilik.�al��an;
import �okbi�imlilik.��retmen;

public class Uygulama3 {

	public static void main(String[] args) {
		�al��an �al��an=new �al��an(1234, "Ahmet", "�al��kan", 1500);
		M�d�r m�d�r=new M�d�r(1235, "Hayri", "Baht�kara", 4000);
		Memur memur=new Memur(1236, "Hale", "Kara", 2000);
		��retmen ��retmen=new ��retmen(1237, "Abdulkadir", "��retir", 3000);
		�al��an.�al��();
		m�d�r.�al��();//Metod Ezme
		memur.�al��();//Metod Ezme
		��retmen.�al��();//Metod Ezme
	}
}
