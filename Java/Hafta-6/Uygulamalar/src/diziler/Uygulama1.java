package diziler;

public class Uygulama1 {

	public static void main(String[] args) {
		int[][]dizi=new int[5][5];
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi.length; j++) {
				if(i==j||i+j==4){
					dizi[i][j]=1;
				}
				else{
					dizi[i][j]=0;
				}
			}
		}
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi.length; j++) {
				System.out.print(dizi[i][j]+"\t");
			}
			System.out.println("");
		}
	}
}