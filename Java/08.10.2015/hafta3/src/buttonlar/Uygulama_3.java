package buttonlar;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JCheckBox;
import javax.swing.JTextField;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Uygulama_3 extends JFrame {

	private JPanel contentPane;
	private JTextField txtToplam;
	int toplamfiyat = 0;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama_3 frame = new Uygulama_3();
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
	public Uygulama_3() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 245, 335);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final JCheckBox chkPantolon = new JCheckBox("Pantolon (100tl)");
		chkPantolon.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (chkPantolon.isSelected()) {
					toplamfiyat +=100;
				}
				else {
					toplamfiyat -=100;
					
				}
				txtToplam.setText("Toplam Fiyat:"+toplamfiyat+" TL");
			}
		});
		chkPantolon.setBounds(6, 29, 145, 28);
		contentPane.add(chkPantolon);
		
		final JCheckBox chkAyakkabi = new JCheckBox("Ayakkab\u0131 (130tl)");
		chkAyakkabi.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (chkAyakkabi.isSelected()) {
					toplamfiyat +=130;
				}
				else {
					toplamfiyat -=130;
					
				}
				txtToplam.setText("Toplam Fiyat:"+toplamfiyat+" TL");
			}
		});
		chkAyakkabi.setBounds(6, 67, 145, 28);
		contentPane.add(chkAyakkabi);
		
		final JCheckBox chkMont = new JCheckBox("Mont (200tl)");
		chkMont.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (chkMont.isSelected()) {
					toplamfiyat +=200;
				}
				else {
					toplamfiyat -=200;
					
				}
				txtToplam.setText("Toplam Fiyat:"+toplamfiyat+" TL");
			}
		});
		chkMont.setBounds(6, 104, 145, 28);
		contentPane.add(chkMont);
		
		final JCheckBox chkKazak = new JCheckBox("Kazak (50tl)");
		chkKazak.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (chkKazak.isSelected()) {
					toplamfiyat +=50;
				}
				else {
					toplamfiyat -=50;
					
				}
				txtToplam.setText("Toplam Fiyat:"+toplamfiyat+ " TL" );
			}
		});
		chkKazak.setBounds(6, 147, 145, 28);
		contentPane.add(chkKazak);
		
		txtToplam = new JTextField();
		txtToplam.setEditable(false);
		txtToplam.setBounds(10, 182, 205, 28);
		contentPane.add(txtToplam);
		txtToplam.setColumns(10);
	}
}
