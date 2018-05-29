package hafta6;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextField;
import javax.swing.JFormattedTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import javax.swing.text.MaskFormatter;
import javax.swing.JScrollPane;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.text.ParseException;

public class Uygulama1 extends JFrame {

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
	 * @throws ParseException 
	 */
	public Uygulama1() throws ParseException {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 348);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final DefaultTableModel tabloModeli=new DefaultTableModel();
		//String[] ba�l�klar={"Ad�","Soyad�","T.C. No."};
		tabloModeli.setColumnIdentifiers(new String[]{"Ad�","Soyad�","T.C.No."});
		MaskFormatter tcNoFormat=new MaskFormatter("###########");
		
		txtAd = new JTextField();
		txtAd.setBounds(10, 11, 160, 29);
		contentPane.add(txtAd);
		txtAd.setColumns(10);
		
		txtSoyad = new JTextField();
		txtSoyad.setColumns(10);
		txtSoyad.setBounds(10, 51, 160, 29);
		contentPane.add(txtSoyad);
		
		final JFormattedTextField txtTcNo = new JFormattedTextField(tcNoFormat);
		txtTcNo.setBounds(10, 91, 160, 29);
		contentPane.add(txtTcNo);
		
		JLabel lblAd = new JLabel("Ad\u0131");
		lblAd.setBounds(180, 11, 71, 29);
		contentPane.add(lblAd);
		
		JLabel lblSoyad = new JLabel("Soyad\u0131");
		lblSoyad.setBounds(180, 51, 71, 29);
		contentPane.add(lblSoyad);
		
		JLabel lblTcNo = new JLabel("T.C. No.");
		lblTcNo.setBounds(180, 91, 71, 29);
		contentPane.add(lblTcNo);
		
		JButton btnEkle = new JButton("Ekle");
		btnEkle.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				for(int i=0;i<tablo.getRowCount();i++){
					if(tabloModeli.getValueAt(i, 2).equals(txtTcNo.getText())){
						return;
					}
				}				
				if(!txtAd.getText().isEmpty()&&!
						txtSoyad.getText().isEmpty()&&txtTcNo.isEditValid())
				tabloModeli.insertRow(0, new String[]{txtAd.getText(),
						txtSoyad.getText(),txtTcNo.getText()});
			}
		});
		btnEkle.setBounds(290, 24, 89, 23);
		contentPane.add(btnEkle);
		
		JButton btnSil = new JButton("Sil");
		btnSil.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				int indis=tablo.getSelectedRow();
				if(indis!=-1)
				tabloModeli.removeRow(indis);
			}
		});
		btnSil.setBounds(290, 57, 89, 23);
		contentPane.add(btnSil);
		
		JButton btnGncelle = new JButton("G\u00FCncelle");
		btnGncelle.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				for(int i=0;i<tablo.getRowCount();i++){
					if(tabloModeli.getValueAt(i, 2).equals(txtTcNo.getText())){
						return;
					}
				}	
				int indis=tablo.getSelectedRow();
				if(indis!=-1&&!txtAd.getText().isEmpty()&&!
					txtSoyad.getText().isEmpty()&&txtTcNo.isEditValid()){
					tabloModeli.removeRow(indis);
					tabloModeli.insertRow(indis,
					new String[]{txtAd.getText(),txtSoyad.getText(),txtTcNo.getText()});
				}
			}
		});
		btnGncelle.setBounds(290, 91, 89, 23);
		contentPane.add(btnGncelle);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(4, 144, 375, 155);
		contentPane.add(scrollPane);
		
		tablo = new JTable(tabloModeli);
		scrollPane.setViewportView(tablo);
		
	}
}
