import java.util.Random;


public class dusesornegi {

	/**
	 * Duses atana kadar zar atan ve dusesi kacýncý seferde buldugunu soyleyen program
	 */
	public static void main(String[] args) {
	Random rasgele=new Random();
	int zar1=0,zar2=0;
	int deneme=0;
	while (zar1!=6||zar2!=6) {
		
		zar1=rasgele.nextInt(6)+1;
		zar2=rasgele.nextInt(6)+1;
		System.out.println("zar1 : "+zar1+" zar2 : "+zar2);
		deneme++;
	}
	
	System.out.println(deneme+" kerede buldunuz ");

	}

}
