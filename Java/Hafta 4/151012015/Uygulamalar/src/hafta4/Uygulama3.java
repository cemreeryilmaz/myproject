package hafta4;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.text.ParseException;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.text.MaskFormatter;
import javax.swing.JFormattedTextField;
import javax.swing.JLabel;
import javax.swing.SwingConstants;
import javax.swing.JButton;
import javax.swing.JTextArea;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Uygulama3 extends JFrame {

	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama3 frame = new Uygulama3();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 * @throws ParseException 
	 */
	public Uygulama3() throws ParseException {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 342, 344);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		MaskFormatter tcNoFormat=new MaskFormatter("###########");
		MaskFormatter telNoFormat=new MaskFormatter("(####)-(### ## ##)");
		MaskFormatter ad�Format=new MaskFormatter("**********");
		ad�Format.setInvalidCharacters("1234567890");
		MaskFormatter do�umTarihiFormat=new MaskFormatter("##/##/####");
		do�umTarihiFormat.setPlaceholderCharacter('_');
		
		final JFormattedTextField txtTcNo = new JFormattedTextField(tcNoFormat);
		txtTcNo.setBounds(10, 27, 179, 20);
		contentPane.add(txtTcNo);
		
		JLabel lblTcNo = new JLabel("T.C. No.");
		lblTcNo.setHorizontalAlignment(SwingConstants.CENTER);
		lblTcNo.setBounds(199, 27, 83, 20);
		contentPane.add(lblTcNo);
		
		final JFormattedTextField txtTelefon = new JFormattedTextField(telNoFormat);
		txtTelefon.setBounds(10, 58, 179, 20);
		contentPane.add(txtTelefon);
		
		JLabel lblTel = new JLabel("Tel.");
		lblTel.setHorizontalAlignment(SwingConstants.CENTER);
		lblTel.setBounds(209, 58, 52, 20);
		contentPane.add(lblTel);
		
		final JFormattedTextField txtAd� = new JFormattedTextField(ad�Format);
		txtAd�.setBounds(10, 89, 179, 20);
		contentPane.add(txtAd�);
		
		JLabel lblAd = new JLabel("Ad\u0131");
		lblAd.setHorizontalAlignment(SwingConstants.CENTER);
		lblAd.setBounds(209, 89, 52, 20);
		contentPane.add(lblAd);
		
		final JFormattedTextField txtDo�umTarihi = new JFormattedTextField(do�umTarihiFormat);
		txtDo�umTarihi.setBounds(10, 120, 179, 20);
		contentPane.add(txtDo�umTarihi);
		
		JLabel lblSoyad = new JLabel("Do\u011Fum Tarihi");
		lblSoyad.setHorizontalAlignment(SwingConstants.CENTER);
		lblSoyad.setBounds(209, 120, 89, 20);
		contentPane.add(lblSoyad);
		
		final JTextArea txtSonu� = new JTextArea();
		txtSonu�.setBounds(10, 185, 281, 110);
		contentPane.add(txtSonu�);
		
		JButton btnKaydet = new JButton("Kaydet");
		btnKaydet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtSonu�.setText("Girilen T.C. Numaras�:"+txtTcNo.getText()+"\n"+
			"Girilen telefon numaras�:"+txtTelefon.getText()+"\n"+
			"Girilen ad:"+txtAd�.getText()+"\n"+
			"Girilen do�um tarihi:"+txtDo�umTarihi.getText());					
			}
		});
		btnKaydet.setBounds(55, 151, 89, 23);
		contentPane.add(btnKaydet);
		
		
	}
}
