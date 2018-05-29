package kalýtým;

import java.awt.Color;

public class Top {	
	Color renk;
	double çap;
	String hammadde;
	
	public Top(Color r,double ç,String h){
		renk=r;
		çap=ç;
		hammadde=h;
	}
	public void zýpla(){
		System.out.println("Top zýpladý.");
	}
	public void yuvarlan(){
		System.out.println("Top yuvarlandý.");
	}
}
