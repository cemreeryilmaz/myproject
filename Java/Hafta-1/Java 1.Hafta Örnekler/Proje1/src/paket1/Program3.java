package paket1;

public class Program3 {

	public static void main(String[] args) {
		
		byte say�1=127;
		//byte say�2=(byte)129;
		int say�2=129;
		System.out.println("Say�1:"+say�1);
		System.out.println("Say�2:"+say�2);		
		/*say�2 de�i�keninin ba�ta veritipi byte se�ilmi�ti ancak hata 
		olu�tu�u i�in iki y�ntem sunuldu. Birincisi cast etmek, cast
		etti�imiz zaman aktarmak istedi�imiz 129 say�s�n�n -127 olarak
		aktar�ld���n� g�rd�k. Bunun nedeni byte de�i�kenin 8 bit alana 
		sahip olmas�. �kincisi ise byte veritipini int ile de�i�tirmek,
		de�i�tirdi�imiz zaman int veritipi 32 bit yer kaplad��� i�in
		129 say�s�n�n aktar�lmas� konusunda bir hata al�nmad�.*/

	}

}
