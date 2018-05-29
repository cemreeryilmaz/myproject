package hafta11;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JFileChooser;
import javax.swing.JMenuBar;
import javax.swing.JMenu;
import javax.swing.JMenuItem;
import javax.swing.JTextPane;
import javax.swing.JScrollPane;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class Uygulama1 extends JFrame {

	private JPanel contentPane;
	private JTextPane metinAlan�;
	File dosya;

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
	 */
	public Uygulama1() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		
		JMenuBar menuBar = new JMenuBar();
		setJMenuBar(menuBar);
		
		JMenu mnDosyaAyaz = new JMenu("Dosya A\u00E7/Yaz");
		menuBar.add(mnDosyaAyaz);
		
		JMenuItem mn�tmDosyaOku = new JMenuItem("Dosya Oku");
		mn�tmDosyaOku.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				JFileChooser dosyaSe�ici=new JFileChooser();
				dosyaSe�ici.showOpenDialog(null);
				dosya=dosyaSe�ici.getSelectedFile();
				try {
					String sat�r="";
					String metin="";
					FileReader dosyaOkuyan=new FileReader(dosya);
					BufferedReader okuyucu=new BufferedReader(dosyaOkuyan);
					sat�r=okuyucu.readLine();
					while(sat�r!=null){
						metin+=sat�r+"\n";
						sat�r=okuyucu.readLine();
					}
					metinAlan�.setText(metin);
				} catch (FileNotFoundException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
		});
		mnDosyaAyaz.add(mn�tmDosyaOku);
		
		JMenuItem mn�tmDosyayaKaydet = new JMenuItem("Dosyaya Kaydet");
		mn�tmDosyayaKaydet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				try {
					FileWriter dosyaYazan=new FileWriter(dosya);
					BufferedWriter yaz�c�=new BufferedWriter(dosyaYazan);
					String metin=metinAlan�.getText()+"\n";
					yaz�c�.write(metin+"\n");
					yaz�c�.close();
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
		});
		mnDosyaAyaz.add(mn�tmDosyayaKaydet);
		
		JMenuItem mn�tmFarklKaydet = new JMenuItem("Farkl\u0131 Kaydet");
		mn�tmFarklKaydet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				JFileChooser dosyaSe�ici=new JFileChooser();
				dosyaSe�ici.showSaveDialog(null);
				dosya=dosyaSe�ici.getSelectedFile();
				 try {
					FileWriter dosyaYazan = new FileWriter(dosya);
					BufferedWriter yaz�c�=new BufferedWriter(dosyaYazan);
					String metin=metinAlan�.getText()+"\n";
					yaz�c�.write(metin+"\n");
					yaz�c�.close();
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				
			}
		});
		mnDosyaAyaz.add(mn�tmFarklKaydet);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 11, 414, 219);
		contentPane.add(scrollPane);
		
		metinAlan� = new JTextPane();
		scrollPane.setViewportView(metinAlan�);
	}
}