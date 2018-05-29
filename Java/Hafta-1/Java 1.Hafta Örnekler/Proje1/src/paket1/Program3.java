package paket1;

public class Program3 {

	public static void main(String[] args) {
		
		byte sayý1=127;
		//byte sayý2=(byte)129;
		int sayý2=129;
		System.out.println("Sayý1:"+sayý1);
		System.out.println("Sayý2:"+sayý2);		
		/*sayý2 deðiþkeninin baþta veritipi byte seçilmiþti ancak hata 
		oluþtuðu için iki yöntem sunuldu. Birincisi cast etmek, cast
		ettiðimiz zaman aktarmak istediðimiz 129 sayýsýnýn -127 olarak
		aktarýldýðýný gördük. Bunun nedeni byte deðiþkenin 8 bit alana 
		sahip olmasý. Ýkincisi ise byte veritipini int ile deðiþtirmek,
		deðiþtirdiðimiz zaman int veritipi 32 bit yer kapladýðý için
		129 sayýsýnýn aktarýlmasý konusunda bir hata alýnmadý.*/

	}

}
