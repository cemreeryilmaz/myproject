package hafta1;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class uygulama2 extends JFrame {

	private JPanel contentPane;
	private JTextField txtkelime;
	private JTextField txtsonuc;

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
		
		txtkelime = new JTextField();
		txtkelime.setBounds(10, 44, 340, 20);
		contentPane.add(txtkelime);
		txtkelime.setColumns(10);
		
		JButton btnHesapla = new JButton("HESAPLA");
		btnHesapla.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				txtsonuc.setText(txtkelime.getText().split(" ").length+" ");
			}
		});
		btnHesapla.setBounds(10, 87, 340, 39);
		contentPane.add(btnHesapla);
		
		txtsonuc = new JTextField();
		txtsonuc.setBounds(10, 150, 340, 20);
		contentPane.add(txtsonuc);
		txtsonuc.setColumns(10);
	}

}
