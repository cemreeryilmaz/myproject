package buttonlar;

import javax.swing.ButtonGroup;

public class ButtonGrubu extends ButtonGroup {
	
	public void HepsiniAc(){
		for (int i = 0; i < this.buttons.size(); i++) {
			this.buttons.get(i).setEnabled(true);
			
			
		}
		
	}
	
	public void HepsiniKapat(){
		
		for (int i = 0; i < this.buttons.size(); i++) {
			this.buttons.get(i).setEnabled(false);
			
			
		}
		
		
	}

}
