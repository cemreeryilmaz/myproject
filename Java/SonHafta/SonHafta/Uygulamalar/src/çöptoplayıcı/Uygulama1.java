package ��ptoplay�c�;

public class Uygulama1 {

	public static void main(String[] args) {
		�al��an �al��an=new �al��an();
		�al��an.adsoyad="Hakan Kurt";
		System.out.println("�al��an�n ad� soyad�:"+�al��an.adsoyad);
		System.out.println("Bo� memory:"+Runtime.getRuntime().freeMemory());
		//�al��an=null;//nesnenin referans� silindi.
		�al��an=new �al��an();//nesnenin referans� silindi.
		System.gc();		
		System.out.println("Bo� memory:"+Runtime.getRuntime().freeMemory());
	}
}
