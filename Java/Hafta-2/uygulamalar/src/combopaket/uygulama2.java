package combopaket;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.DefaultComboBoxModel;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JComboBox;
import javax.swing.JTextField;

public class uygulama2 extends JFrame {

	private JPanel contentPane;
	private JTextField metinAlan�;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					uygulama2 frame = new uygulama2();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public uygulama2() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		String[] g�nler ={"Pazartesi","Sal�","�ar�amba","Per�embe","Cuma","Cumartesi","Pazar"};
		DefaultComboBoxModel<String> model=new DefaultComboBoxModel<String>(g�nler);
		//model.addElement("Pazartesi");
		//model.addElement("Sal�");
		//model.addElement("�ar�amba");
		//
		// Olu�turdu�umuz modeli comboBox'�n i�ine koymazsan model �al��maz..!!!!
		
		JComboBox comboBox = new JComboBox(model);
		comboBox.setBounds(10, 25, 187, 20);
		contentPane.add(comboBox);
		
		metinAlan� = new JTextField();
		metinAlan�.setBounds(223, 25, 179, 20);
		contentPane.add(metinAlan�);
		metinAlan�.setColumns(10);
	}

}
