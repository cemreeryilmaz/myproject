import java.util.Random;

public class Uygulama3 {

	public static void main(String[] args) {
		Random rasgele=new Random();
		int[]dizi=new int[10];
		//dizinin i�erisini rasgele say� ile dolduruyoruz.
		for (int i = 0; i < dizi.length; i++) {
			dizi[i]=rasgele.nextInt(100);
		}
		//S�ralama i�lemi...
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi.length-1; j++) {
				if(dizi[j]<dizi[j+1]){
					int ge�ici=dizi[j+1];
					dizi[j+1]=dizi[j];
					dizi[j]=ge�ici;
				}
			}
		}
		for (int i : dizi) {
			System.out.print(i+" ");
		}

	}

}
