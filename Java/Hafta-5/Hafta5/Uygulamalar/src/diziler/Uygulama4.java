package diziler;

public class Uygulama4 {

	public static void main(String[] args) {
		int [][]dizi=new int[5][5];
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi[i].length; j++) {
				dizi[i][j]=(int) Math.pow((i*5+j), 2);
			}
		}
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi[i].length; j++) {
				System.out.print(dizi[i][j]+"\t");
			}
			System.out.println("");
		}
	}
}
