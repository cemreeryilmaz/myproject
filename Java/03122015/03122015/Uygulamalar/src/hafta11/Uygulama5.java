package hafta11;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JTable;
import javax.swing.JScrollPane;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Uygulama5 extends JFrame {

	private JPanel contentPane;
	private JTextField txtAd;
	private JTextField txtSoyad;
	private JTable tablo;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama5 frame = new Uygulama5();
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
	public Uygulama5() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 308, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final DefaultTableModel tabloModeli=new DefaultTableModel();
		tabloModeli.setColumnIdentifiers(new String[]{"Ad�","Soyad�","G�revi"});
		
		txtAd = new JTextField();
		txtAd.setBounds(10, 11, 149, 31);
		contentPane.add(txtAd);
		txtAd.setColumns(10);
		
		JLabel lblAd = new JLabel("Ad\u0131");
		lblAd.setBounds(169, 11, 105, 31);
		contentPane.add(lblAd);
		
		txtSoyad = new JTextField();
		txtSoyad.setColumns(10);
		txtSoyad.setBounds(10, 53, 149, 31);
		contentPane.add(txtSoyad);
		
		JLabel lblSoyad = new JLabel("Soyad\u0131");
		lblSoyad.setBounds(169, 53, 105, 31);
		contentPane.add(lblSoyad);
		
		JButton btnKaydet = new JButton("Kaydet");
		btnKaydet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(txtAd.getText().isEmpty()||txtSoyad.getText().isEmpty()){
					JOptionPane.showMessageDialog(null, "Ad veya Soyad girmediniz", "Hata", 
					JOptionPane.ERROR_MESSAGE, null);
				}else{
				String[] g�revler={"Pazarlama","Sat��","Muhasebe","�nsan Kaynaklar�"};
				Object g�rev=JOptionPane.showInputDialog(null, "Ki�inin g�revini giriniz", "Se�im",
				JOptionPane.INFORMATION_MESSAGE, null, 
				g�revler, g�revler[0]);
				if(g�rev!=null){
					tabloModeli.insertRow(0, new Object[]{txtAd.getText(),txtSoyad.getText(),g�rev});
				}
				}				
			}
		});
		btnKaydet.setBounds(10, 95, 149, 36);
		contentPane.add(btnKaydet);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 154, 264, 97);
		contentPane.add(scrollPane);
		
		tablo = new JTable(tabloModeli);
		scrollPane.setViewportView(tablo);
	}
}
