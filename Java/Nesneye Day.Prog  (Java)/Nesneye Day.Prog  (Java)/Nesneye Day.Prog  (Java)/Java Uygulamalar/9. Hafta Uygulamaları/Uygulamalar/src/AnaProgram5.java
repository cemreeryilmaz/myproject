import java.awt.Color;

public class AnaProgram5 {
	
	public static void main(String[] args) {
		Top top1=new Top(12.3,Color.yellow,"deri",5);
		Top top2=new Top(10.9,Color.white,"s�nger",6);
		System.out.println("Top 1 in �zellikleri");
		System.out.println("Top 1 in �ap�:"+top1.�ap);
		System.out.println("Top 1 in rengi:"+top1.renk);
		System.out.println("Top 1 in hammaddesi:"+top1.hammadde);
		System.out.println("Top 1 in elastikiyeti:"+top1.elastikiyet);
		System.out.println("-------------------------------");
		System.out.println("Top 2 nin �zellikleri");
		System.out.println("Top 2 nin �ap�:"+top2.�ap);
		System.out.println("Top 2 nin rengi:"+top2.renk);
		System.out.println("Top 2 nin hammaddesi:"+top2.hammadde);
		System.out.println("Top 2 nin elastikiyeti:"+top2.elastikiyet);
	}
}
