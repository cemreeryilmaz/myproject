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

public class Uygulama1 extends JFrame {

	private JPanel contentPane;
	private JPasswordField �ifreAlan�;
	private JTextField txtSonu�;
	String �ifre="12345";
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama1 frame = new Uygulama1();
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
	public Uygulama1() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 249, 181);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		�ifreAlan� = new JPasswordField();
		�ifreAlan�.setBounds(20, 24, 190, 28);
		contentPane.add(�ifreAlan�);
		
		JButton btnGiriYap = new JButton("Giri\u015F Yap");
		btnGiriYap.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if(�ifreAlan�.getText().equals(�ifre)){
					txtSonu�.setText("�ifre Do�ru");
				}
				else{
					txtSonu�.setText("�ifre Yanl��");
				}
			}
		});
		btnGiriYap.setBounds(20, 63, 190, 28);
		contentPane.add(btnGiriYap);
		
		txtSonu� = new JTextField();
		txtSonu�.setEditable(false);
		txtSonu�.setBounds(20, 102, 190, 28);
		contentPane.add(txtSonu�);
		txtSonu�.setColumns(10);
	}
}
