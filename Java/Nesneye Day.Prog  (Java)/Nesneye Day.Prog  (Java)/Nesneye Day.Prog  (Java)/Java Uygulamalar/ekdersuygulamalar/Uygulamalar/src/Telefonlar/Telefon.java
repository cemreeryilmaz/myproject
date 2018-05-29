package Telefonlar;

public abstract class Telefon {
	public abstract void aramaYap();
	
	public void smsGönder(){
		System.out.println("sms gönderildi");
	}
}
