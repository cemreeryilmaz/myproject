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

public class Uygulama3 extends JFrame {

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
	 */
	public Uygulama3() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 306, 236);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		txtAd = new JTextField();
		txtAd.setBounds(10, 23, 170, 30);
		contentPane.add(txtAd);
		txtAd.setColumns(10);
		
		JLabel lblAd = new JLabel("Ad\u0131");
		lblAd.setBounds(190, 23, 70, 30);
		contentPane.add(lblAd);
		
		txtSoyad = new JTextField();
		txtSoyad.setColumns(10);
		txtSoyad.setBounds(10, 67, 170, 30);
		contentPane.add(txtSoyad);
		
		JLabel lblSoyad = new JLabel("Soyad\u0131");
		lblSoyad.setBounds(190, 67, 70, 30);
		contentPane.add(lblSoyad);
		
		JButton btnBirletir = new JButton("Birle\u015Ftir");
		btnBirletir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				int se�enek=JOptionPane.showConfirmDialog(null, "Birle�tirmeyi onayl�yor musunuz?", "Onay",
				JOptionPane.YES_NO_CANCEL_OPTION, JOptionPane.QUESTION_MESSAGE, null);
				System.out.println(se�enek);
				if(se�enek==0){
					txtAdSoyad.setText(txtAd.getText()+" "+txtSoyad.getText());
				}
				else if(se�enek==1){
					txtAd.setText(null);
					txtSoyad.setText(null);
					txtAdSoyad.setText(null);
				}
			}
		});
		btnBirletir.setBounds(10, 108, 170, 30);
		contentPane.add(btnBirletir);
		
		txtAdSoyad = new JTextField();
		txtAdSoyad.setEditable(false);
		txtAdSoyad.setColumns(10);
		txtAdSoyad.setBounds(10, 149, 170, 30);
		contentPane.add(txtAdSoyad);
		
		JLabel lblAdsoyad = new JLabel("Ad\u0131-Soyad\u0131");
		lblAdsoyad.setBounds(190, 149, 70, 30);
		contentPane.add(lblAdsoyad);
	}
}
