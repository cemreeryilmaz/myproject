package hafta11;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Uygulama4 extends JFrame {

	private JPanel contentPane;
	private JTextField txtAd;
	private JTextField txtSoyad;
	private JTextField txtAdSoyad;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama4 frame = new Uygulama4();
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
	public Uygulama4() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 297, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		txtAd = new JTextField();
		txtAd.setBounds(24, 23, 172, 37);
		contentPane.add(txtAd);
		txtAd.setColumns(10);
		
		JLabel lblAd = new JLabel("Ad\u0131");
		lblAd.setBounds(206, 23, 88, 37);
		contentPane.add(lblAd);
		
		txtSoyad = new JTextField();
		txtSoyad.setColumns(10);
		txtSoyad.setBounds(24, 77, 172, 37);
		contentPane.add(txtSoyad);
		
		JLabel lblSoyad = new JLabel("Soyad\u0131");
		lblSoyad.setBounds(206, 77, 88, 37);
		contentPane.add(lblSoyad);
		
		txtAdSoyad = new JTextField();
		txtAdSoyad.setEditable(false);
		txtAdSoyad.setColumns(10);
		txtAdSoyad.setBounds(24, 171, 172, 37);
		contentPane.add(txtAdSoyad);
		
		JLabel lblAdsoyad = new JLabel("Ad\u0131-Soyad\u0131");
		lblAdsoyad.setBounds(206, 171, 88, 37);
		contentPane.add(lblAdsoyad);
		
		JButton btnBirletir = new JButton("Birle\u015Ftir");
		btnBirletir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				int seçenek=JOptionPane.showOptionDialog(null, "Birleþtirmeyi onaylýyor musunuz?", "Onay",
				JOptionPane.YES_NO_CANCEL_OPTION, JOptionPane.QUESTION_MESSAGE, null,
				new String[]{"Birleþtir","Temizle","Kalsýn"}, null);
				if(seçenek==0){
					txtAdSoyad.setText(txtAd.getText()+" "+txtSoyad.getText());
				}
				else if(seçenek==1){
					txtAd.setText(null);
					txtSoyad.setText(null);
					txtAdSoyad.setText(null);
				}
			}
		});
		btnBirletir.setBounds(34, 121, 150, 39);
		contentPane.add(btnBirletir);
	}

}
