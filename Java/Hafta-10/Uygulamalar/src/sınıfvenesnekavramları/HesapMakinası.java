package s�n�fvenesnekavramlar�;

import java.awt.Color;

public class HesapMakinas� {
	
	String �ekil;
	int digitsay�s�;
	int tu�say�s�;
	Color renk;
	
	public HesapMakinas�(String �,int d,int t,Color r){
		�ekil=�;
		digitsay�s�=d;
		tu�say�s�=t;
		renk=r;
	}
	public double toplamaYap(double say�1,double say�2){
		return say�1+say�2;
	}
	public double ��karmaYap(double say�1,double say�2){
		return say�1-say�2;
	}
	public double b�lmeYap(double say�1,double say�2){
		return say�1/say�2;
	}
	public double �arpmaYap(double say�1,double say�2){
		return say�1*say�2;
	}
}
