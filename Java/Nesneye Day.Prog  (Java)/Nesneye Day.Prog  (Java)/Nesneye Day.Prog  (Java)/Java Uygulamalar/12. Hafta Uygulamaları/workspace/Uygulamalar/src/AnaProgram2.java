
public class AnaProgram2 {
	
	public static void main(String[] args) {
		/*��retmen ��retmen1=new ��retmen();
		��retmen1.dersAnlat();
		��retmen1.�al��();
		System.out.println("��retmenin �al��ma saati:"+��retmen1.saatS�yle());
		
		�al��an ��retmen2=��retmen1;//Yukar� �evrim (UpCasting)
*/		
		�al��an �al��an1=new ��retmen();
		//A�a�� �evrim yapmak istiyorsak �evrim yapmadan �nce
		//�st s�n�ftan olu�turdu�umuz nesneyi �evrim yapaca��m�z alt s�n�fa
		//referans g�stermek zorunday�z, aksi halde hata al�r�z.
		�al��an1.�al��();
		
		
		��retmen ay�e=(��retmen) �al��an1;
		ay�e.dersAnlat();
	}
}
