import java.util.Scanner;

public class Uygulama7 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		String[]dizi=new String[5];
		for (int i = 0; i < dizi.length; i++) {
			System.out.println((i+1)+".nci ismi giriniz:");
			dizi[i]=klavye.nextLine();
		}
		String[]s�ralanm��dizi=diziyiS�rala(dizi);
		for (int i = 0; i < s�ralanm��dizi.length; i++) {
			System.out.println(s�ralanm��dizi[i]+"\t");
		}
	}
	private static String[] diziyiS�rala(String[] dizi) {
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi.length-1; j++) {
				if(dizi[j].compareTo(dizi[j+1])<0){
					String ge�ici=dizi[j+1];
					dizi[j+1]=dizi[j];
					dizi[j]=ge�ici;
				}
			}
		}
		return dizi;
	}
}
