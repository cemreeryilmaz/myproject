package nesneserile�tirme;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.ObjectInputStream;

public class Uygulama3 {

	public static void main(String[] args) throws FileNotFoundException, IOException, ClassNotFoundException {
		ObjectInputStream ��k��=new ObjectInputStream(new FileInputStream(new File("veri.txt")));
		Top top2=(Top) ��k��.readObject();
		System.out.println("Okunan nesnenin rengi:"+top2.renk);
		System.out.println("Okunan nesnenin hammaddesi:"+top2.hammadde);
		System.out.println("Okunan nesnenin �ap�:"+top2.�ap);
		System.out.println("Okunan nesnenin elastikiyeti:"+top2.elastikiyet);
		��k��.close();
	}
}
