package finalkelimesi;

public class Memur extends Çalýþan {
	//Kalýtým yapýlamadý çünkü Çalýþan sýnýfý final olarak belirlendiði için
	//Çalýþan sýnýfý kalýtýma kapatýldý.
	public void çalýþ(){
		System.out.println("Memur evrak iþlerini yerine getirdi.");
	}
	//Çalýþan sýnýfýnýn içindeki çalýþ metodu final olduðu için alt sýnýfta
	//overrride edilemedi, yani ezilemedi.
}
