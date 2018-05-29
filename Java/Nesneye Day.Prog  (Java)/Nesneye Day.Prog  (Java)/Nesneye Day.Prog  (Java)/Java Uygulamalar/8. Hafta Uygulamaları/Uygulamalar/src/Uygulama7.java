import java.util.Scanner;

public class Uygulama7 {

	public static void main(String[] args) {
		Scanner klavye=new Scanner(System.in);
		String[]dizi=new String[5];
		for (int i = 0; i < dizi.length; i++) {
			System.out.println((i+1)+".nci ismi giriniz:");
			dizi[i]=klavye.nextLine();
		}
		String[]sýralanmýþdizi=diziyiSýrala(dizi);
		for (int i = 0; i < sýralanmýþdizi.length; i++) {
			System.out.println(sýralanmýþdizi[i]+"\t");
		}
	}
	private static String[] diziyiSýrala(String[] dizi) {
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi.length-1; j++) {
				if(dizi[j].compareTo(dizi[j+1])<0){
					String geçici=dizi[j+1];
					dizi[j+1]=dizi[j];
					dizi[j]=geçici;
				}
			}
		}
		return dizi;
	}
}
