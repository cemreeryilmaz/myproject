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
	private JTextField metinAlaný;

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
		
		String[] günler ={"Pazartesi","Salý","Çarþamba","Perþembe","Cuma","Cumartesi","Pazar"};
		DefaultComboBoxModel<String> model=new DefaultComboBoxModel<String>(günler);
		//model.addElement("Pazartesi");
		//model.addElement("Salý");
		//model.addElement("Çarþamba");
		//
		// Oluþturduðumuz modeli comboBox'ýn içine koymazsan model çalýþmaz..!!!!
		
		JComboBox comboBox = new JComboBox(model);
		comboBox.setBounds(10, 25, 187, 20);
		contentPane.add(comboBox);
		
		metinAlaný = new JTextField();
		metinAlaný.setBounds(223, 25, 179, 20);
		contentPane.add(metinAlaný);
		metinAlaný.setColumns(10);
	}

}
