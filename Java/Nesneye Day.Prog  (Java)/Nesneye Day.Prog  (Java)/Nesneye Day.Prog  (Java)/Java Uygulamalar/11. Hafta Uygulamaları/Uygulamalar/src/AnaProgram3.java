import java.util.Scanner;

public class AnaProgram3 {

	public static void main(String[] args) {
		/*�al��an �al��an1=new �al��an();
		M�d�r m�d�r1=new M�d�r();
		Memur memur1=new Memur();*/
		��retmen ��retmen1=new ��retmen();
		Scanner klavye=new Scanner(System.in);
		/*�al��an1.�al��();
		m�d�r1.�al��();
		memur1.�al��();*/
		System.out.println("��retmen ka� saat �al��s�n?:");
		int saat=klavye.nextInt();
		��retmen1.�al��(saat);		
	}
}
