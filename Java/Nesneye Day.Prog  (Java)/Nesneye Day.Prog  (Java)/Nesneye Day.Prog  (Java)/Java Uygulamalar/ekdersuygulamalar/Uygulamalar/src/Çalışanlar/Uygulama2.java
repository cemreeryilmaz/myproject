package �al��anlar;

public class Uygulama2 {

	public static void main(String[] args) {
		��retmen ay�e=new ��retmen();
		ay�e.uzmanl�kalan�="Tarih";
		//uzmanl�kalan� de�i�keni final oldu�u i�in
		//de�eri de�i�tirilemez.
		String kelime=ay�e.uzmanl�kalan�;
		//uzmanl�kalan� final olsa da eri�ilebilir ama
		//final de�i�kenin de�eri de�i�tirilemez.
		�al��an yeni�al��an=new �al��an();
		yeni�al��an.tcno="1234545";
		
	}
}
