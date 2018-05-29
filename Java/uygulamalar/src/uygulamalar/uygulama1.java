package uygulamalar;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JButton;
import javax.swing.JTextField;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class uygulama1 extends JFrame {

	private JPanel contentPane;
	private JTextField txtgiris;
	private JTextField txtSonuc;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					uygulama1 frame = new uygulama1();
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
	public uygulama1() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 349, 333);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JButton btnHesapla = new JButton("HESAPLA");
		btnHesapla.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				txtSonuc.setText("Girdiğiniz kelime "+txtgiris.getText().length()+" karakterden oluşmaktadır..");
				
			}
		});
		btnHesapla.setBounds(14, 80, 262, 23);
		contentPane.add(btnHesapla);
		
		txtgiris = new JTextField();
		txtgiris.setBounds(17, 49, 259, 20);
		contentPane.add(txtgiris);
		txtgiris.setColumns(10);
		
		txtSonuc = new JTextField();
		txtSonuc.setEditable(false);
		txtSonuc.setColumns(10);
		txtSonuc.setBounds(20, 124, 256, 20);
		contentPane.add(txtSonuc);
	}
}
