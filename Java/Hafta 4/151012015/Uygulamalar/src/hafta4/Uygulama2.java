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
	private JPasswordField �ifreAlan�;
	private JTextField txtSonu�;

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
		
		�ifreAlan� = new JPasswordField();
		�ifreAlan�.setBounds(10, 11, 190, 26);
		contentPane.add(�ifreAlan�);
		
		JButton btnNewButton = new JButton("Giri\u015F Yap");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {				
				if(Arrays.equals(�ifreAlan�.getPassword(), "12345".toCharArray())){
					txtSonu�.setText("�ifre Do�ru");
				}
				else{
					txtSonu�.setText("�ifre Yanl��");
				}
			}
		});
		btnNewButton.setBounds(10, 48, 190, 26);
		contentPane.add(btnNewButton);
		
		txtSonu� = new JTextField();
		txtSonu�.setEditable(false);
		txtSonu�.setBounds(10, 85, 190, 26);
		contentPane.add(txtSonu�);
		txtSonu�.setColumns(10);
	}

}
