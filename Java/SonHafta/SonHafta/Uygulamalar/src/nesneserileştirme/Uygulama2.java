package nesneserileþtirme;

import java.awt.Color;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;

public class Uygulama2 {

	public static void main(String[] args) throws FileNotFoundException, IOException {
		ObjectOutputStream giriþ=new ObjectOutputStream(new FileOutputStream("veri.txt"));
		Top top1=new Top();
		top1.elastikiyet=10;
		top1.renk=Color.blue;
		top1.hammadde="Deri";
		top1.çap=23.45;
		giriþ.writeObject(top1);
		giriþ.close();
	}
}
