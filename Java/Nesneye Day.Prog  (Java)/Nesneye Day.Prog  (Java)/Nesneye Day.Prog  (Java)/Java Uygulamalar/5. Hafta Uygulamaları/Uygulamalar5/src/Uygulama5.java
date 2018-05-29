
public class Uygulama5 {

	public static void main(String[] args) {
		int[][]dizi=new int[4][4];
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi.length; j++) {
				if(i==j){
					dizi[i][j]=0;
				}
				else
				{
					dizi[i][j]=i*4+j+1;
				}}}
		for (int i = 0; i < dizi.length; i++) {
			for (int j = 0; j < dizi.length; j++) {
				System.out.print(dizi[i][j]+"\t");
			}
			System.out.println();
		}}}