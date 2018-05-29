package hafta4;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JPasswordField;
import javax.swing.JButton;
import javax.swing.JTextField;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.util.Arrays;

public class Uygulama2 extends JFrame {

	private JPanel contentPane;
	private JPasswordField þifreAlaný;
	private JTextField txtSonuç;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama2 frame = new Uygulama2();
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
	public Uygulama2() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 229, 162);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		þifreAlaný = new JPasswordField();
		þifreAlaný.setBounds(10, 11, 190, 26);
		contentPane.add(þifreAlaný);
		
		JButton btnNewButton = new JButton("Giri\u015F Yap");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {				
				if(Arrays.equals(þifreAlaný.getPassword(), "12345".toCharArray())){
					txtSonuç.setText("Þifre Doðru");
				}
				else{
					txtSonuç.setText("Þifre Yanlýþ");
				}
			}
		});
		btnNewButton.setBounds(10, 48, 190, 26);
		contentPane.add(btnNewButton);
		
		txtSonuç = new JTextField();
		txtSonuç.setEditable(false);
		txtSonuç.setBounds(10, 85, 190, 26);
		contentPane.add(txtSonuç);
		txtSonuç.setColumns(10);
	}

}
