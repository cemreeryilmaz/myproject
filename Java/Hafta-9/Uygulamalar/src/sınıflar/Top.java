package s�n�flar;

import java.awt.Color;

public class Top {
	
	int elastikiyet;
	double �ap;
	Color renk;
	String hammadde;
	
	public Top(int e,double �,Color r,String h){
		elastikiyet=e;
		�ap=�;
		renk=r;
		hammadde=h;
	}
	public Top(int e,double �,Color r){
		elastikiyet=e;
		�ap=�;
		renk=r;
	}
	public Top(double �,Color r){
		�ap=�;
		renk=r;
	}	
	public Top() {
		// TODO Auto-generated constructor stub
	}
	public void z�pla(){
		System.out.println("Top z�plad�.");
	}
	public void yuvarlan(){
		System.out.println("Top yuvarland�.");
	}

}
