package hafta5;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.text.ParseException;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.text.MaskFormatter;
import javax.swing.DefaultListModel;
import javax.swing.JTextField;
import javax.swing.JFormattedTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JList;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class Uygulama1 extends JFrame {

	private JPanel contentPane;
	private JTextField txtAd;
	private JTextField txtSoyad;
	JList<String> lstAd;
	JList<String> lstSoyad;
	JList<String> lstTcNo;

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
		setBounds(100, 100, 450, 355);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		MaskFormatter tcNoFormat=new MaskFormatter("###########");
		final DefaultListModel<String> adModeli=new DefaultListModel<String>();
		final DefaultListModel<String> soyadModeli=new DefaultListModel<String>();
		final DefaultListModel<String> tcNoModeli=new DefaultListModel<String>();
		
		txtAd = new JTextField();
		txtAd.setBounds(10, 11, 179, 27);
		contentPane.add(txtAd);
		txtAd.setColumns(10);
				
		txtSoyad = new JTextField();
		txtSoyad.setColumns(10);
		txtSoyad.setBounds(10, 49, 179, 27);
		contentPane.add(txtSoyad);
		
		final JFormattedTextField txtTcNo = new JFormattedTextField(tcNoFormat);
		txtTcNo.setBounds(10, 87, 179, 27);
		contentPane.add(txtTcNo);
		
		JLabel lblAd = new JLabel("Ad\u0131");
		lblAd.setBounds(200, 11, 64, 27);
		contentPane.add(lblAd);
		
		JLabel lblSoyad = new JLabel("Soyad\u0131");
		lblSoyad.setBounds(200, 49, 64, 27);
		contentPane.add(lblSoyad);
		
		JLabel lblTcNo = new JLabel("T.C. No.");
		lblTcNo.setBounds(200, 87, 64, 27);
		contentPane.add(lblTcNo);
		
		JButton btnEkle = new JButton("Ekle");
		btnEkle.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {				
				if(txtAd.getText().length()!=0&&txtSoyad.getText().length()!=0&&txtTcNo.isEditValid()){
					String[] dizi=new String[tcNoModeli.getSize()];
					for (int i = 0; i < dizi.length; i++) {
						dizi[i]=tcNoModeli.elementAt(i);
					}
					for (int i = 0; i < dizi.length; i++) {
						if(dizi[i].equals(txtTcNo.getText())){
							return;
						}
					}					
				adModeli.insertElementAt(txtAd.getText(), adModeli.getSize());
				soyadModeli.insertElementAt(txtSoyad.getText(), soyadModeli.getSize());
				tcNoModeli.insertElementAt(txtTcNo.getText(), tcNoModeli.getSize());
				}
			}
		});
		btnEkle.setBounds(274, 13, 89, 23);
		contentPane.add(btnEkle);
		
		JButton btnSil = new JButton("Sil");
		btnSil.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				int indis=lstAd.getSelectedIndex();
				if(indis!=-1){
				adModeli.removeElementAt(indis);
				soyadModeli.removeElementAt(indis);
				tcNoModeli.removeElementAt(indis);
				}
			}
		});
		btnSil.setBounds(274, 51, 89, 23);
		contentPane.add(btnSil);
		
		JButton btnGncelle = new JButton("G\u00FCncelle");
		btnGncelle.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				int indis=lstAd.getSelectedIndex();
				if(txtAd.getText().length()!=0&&txtSoyad.getText().length()!=0&&txtTcNo.isEditValid()&&indis!=-1){
					String[] dizi=new String[tcNoModeli.getSize()];
					for (int i = 0; i < dizi.length; i++) {
						dizi[i]=tcNoModeli.elementAt(i);
					}
					for (int i = 0; i < dizi.length; i++) {
						if(dizi[i].equals(txtTcNo.getText())){
							return;
						}
					}		
				adModeli.removeElementAt(indis);
				soyadModeli.removeElementAt(indis);
				tcNoModeli.removeElementAt(indis);
				adModeli.insertElementAt(txtAd.getText(), indis);
				soyadModeli.insertElementAt(txtSoyad.getText(), indis);
				tcNoModeli.insertElementAt(txtTcNo.getText(), indis);
				}
			}
		});
		btnGncelle.setBounds(274, 85, 89, 23);
		contentPane.add(btnGncelle);
		
		lstAd = new JList<String>(adModeli);
		lstAd.addMouseListener(new MouseAdapter() {
			public void mousePressed(MouseEvent arg0) {
				int indis=lstAd.getSelectedIndex();
				lstSoyad.setSelectedIndex(indis);
				lstTcNo.setSelectedIndex(indis);				
			}
		});
		lstAd.setBounds(10, 148, 112, 158);
		contentPane.add(lstAd);
		
		lstSoyad = new JList<String>(soyadModeli);
		lstSoyad.addMouseListener(new MouseAdapter() {
			public void mousePressed(MouseEvent arg0) {
				int indis=lstSoyad.getSelectedIndex();
				lstAd.setSelectedIndex(indis);
				lstTcNo.setSelectedIndex(indis);
			}
		});
		lstSoyad.setBounds(152, 148, 112, 158);
		contentPane.add(lstSoyad);
		
		lstTcNo = new JList<String>(tcNoModeli);
		lstTcNo.addMouseListener(new MouseAdapter() {
			public void mousePressed(MouseEvent arg0) {
				int indis=lstTcNo.getSelectedIndex();
				lstAd.setSelectedIndex(indis);
				lstSoyad.setSelectedIndex(indis);
			}
		});
		lstTcNo.setBounds(289, 148, 112, 158);
		contentPane.add(lstTcNo);
		
		JLabel label = new JLabel("Ad\u0131");
		label.setBounds(10, 121, 64, 27);
		contentPane.add(label);
		
		JLabel label_1 = new JLabel("Soyad\u0131");
		label_1.setBounds(152, 125, 64, 23);
		contentPane.add(label_1);
		
		JLabel label_2 = new JLabel("T.C. No.");
		label_2.setBounds(284, 125, 64, 18);
		contentPane.add(label_2);
	}
}
