package hafta11;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JButton;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Uygulama2 extends JFrame {

	private JPanel contentPane;

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
		setBounds(100, 100, 178, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JButton btnBoMesaj = new JButton("Bo\u015F Mesaj");
		btnBoMesaj.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null, "Bu bir bo� mesaj �rne�idir",
				"Bo� Mesaj", JOptionPane.PLAIN_MESSAGE, null);
			}
		});
		btnBoMesaj.setBounds(10, 11, 128, 36);
		contentPane.add(btnBoMesaj);
		
		JButton btnHataMesaj = new JButton("Hata Mesaj\u0131");
		btnHataMesaj.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null, "Hata Mesaj� �rne�idir", "Hata Mesaj�",
				JOptionPane.ERROR_MESSAGE, null);
			}
		});
		btnHataMesaj.setBounds(10, 58, 128, 36);
		contentPane.add(btnHataMesaj);
		
		JButton btnUyarMesaj = new JButton("Uyar\u0131 Mesaj\u0131");
		btnUyarMesaj.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null, "Bu bir uyar� mesaj�d�r",
				"Uyar� Mesaj�", JOptionPane.WARNING_MESSAGE, null);
			}
		});
		btnUyarMesaj.setBounds(10, 108, 128, 36);
		contentPane.add(btnUyarMesaj);
		
		JButton btnBilgiMesaj = new JButton("Bilgi Mesaj\u0131");
		btnBilgiMesaj.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null, "Bu bir bilgi mesaj�d�r", "Bilgi Mesaj�",
						JOptionPane.INFORMATION_MESSAGE, null);
			}
		});
		btnBilgiMesaj.setBounds(10, 155, 128, 36);
		contentPane.add(btnBilgiMesaj);
		
		JButton btnSoruMesaj = new JButton("Soru Mesaj\u0131");
		btnSoruMesaj.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null, "Bu bir soru mesaj�d�r", "Soru Mesaj�", 
						JOptionPane.QUESTION_MESSAGE, null);
			}
		});
		btnSoruMesaj.setBounds(10, 201, 128, 36);
		contentPane.add(btnSoruMesaj);
	}
}
