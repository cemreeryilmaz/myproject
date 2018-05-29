package uygulamalar;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JLabel;

public class uygulama2 extends JFrame {

	private JPanel contentPane;
	private JTextField txtAd;
	private JTextField txtSoyadi;
	private JTextField txtAdSoyad;
	JLabel lblKaraktersayisi;

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
		setBounds(100, 100, 471, 382);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		txtAd = new JTextField();
		txtAd.setBounds(22, 37, 238, 20);
		contentPane.add(txtAd);
		txtAd.setColumns(10);
		
		txtSoyadi = new JTextField();
		txtSoyadi.setBounds(22, 87, 238, 20);
		contentPane.add(txtSoyadi);
		txtSoyadi.setColumns(10);
		
		txtAdSoyad = new JTextField();
		txtAdSoyad.setBounds(22, 195, 238, 20);
		contentPane.add(txtAdSoyad);
		txtAdSoyad.setColumns(10);
		
		JButton btnBirlestir = new JButton("Birle\u015Ftir");
		btnBirlestir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String ad=txtAd.getText();
				String soyad = txtSoyadi.getText();
				String adsoyad = ad + " " + soyad; 
				txtAdSoyad.setText(txtAd.getText().concat(" " + txtSoyadi.getText()));
				lblKaraktersayisi.setText((ad + " " + soyad).length()+" ");
				
			}
		});
		btnBirlestir.setBounds(22, 144, 238, 23);
		contentPane.add(btnBirlestir);
		
		JLabel lblAdi = new JLabel("Ad\u0131:");
		lblAdi.setBounds(270, 37, 63, 17);
		contentPane.add(lblAdi);
		
		JLabel lblSoyadi = new JLabel("Soyad\u0131:");
		lblSoyadi.setBounds(270, 90, 63, 17);
		contentPane.add(lblSoyadi);
		
		JLabel lblAdsoyad = new JLabel("AdSoyad");
		lblAdsoyad.setBounds(270, 195, 63, 17);
		contentPane.add(lblAdsoyad);
		
		lblKaraktersayisi = new JLabel("Karakter say\u0131s\u0131 burada g\u00F6sterilicektir.");
		lblKaraktersayisi.setBounds(22, 226, 238, 63);
		contentPane.add(lblKaraktersayisi);
	}
}
