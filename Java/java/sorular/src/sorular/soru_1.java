package sorular;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import javax.swing.Timer;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JToggleButton;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class soru_1 extends JFrame {

	private JPanel contentPane;
	private JTextField txtSaat;
	private JTextField txtDakika;
	private JTextField txtSaniye;

	
	Timer t;
	int saat =0,dakika=0,saniye=0;
	

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					soru_1 frame = new soru_1();
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
	public soru_1() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		txtSaat = new JTextField();
		txtSaat.setEditable(false);
		txtSaat.setBounds(10, 11, 73, 43);
		contentPane.add(txtSaat);
		txtSaat.setColumns(10);
		
		txtDakika = new JTextField();
		txtDakika.setEditable(false);
		txtDakika.setColumns(10);
		txtDakika.setBounds(103, 11, 73, 43);
		contentPane.add(txtDakika);
		
		txtSaniye = new JTextField();
		txtSaniye.setEditable(false);
		txtSaniye.setColumns(10);
		txtSaniye.setBounds(212, 11, 73, 43);
		contentPane.add(txtSaniye);
		
		JLabel lblSaat = new JLabel("Saat");
		lblSaat.setBounds(20, 65, 46, 14);
		contentPane.add(lblSaat);
		
		JLabel lblDakika = new JLabel("Dakika");
		lblDakika.setBounds(113, 65, 46, 14);
		contentPane.add(lblDakika);
		
		JLabel lblSaniye = new JLabel("Saniye");
		lblSaniye.setBounds(222, 65, 46, 14);
		contentPane.add(lblSaniye);
		
		final JToggleButton tglbtnBaslatDurdur = new JToggleButton("Ba\u015Flat / Durdur");
		tglbtnBaslatDurdur.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (tglbtnBaslatDurdur.isSelected()) {
					t.start();
				}
				else {
					t.stop();
				}
			}
			}
		);
		

				
		tglbtnBaslatDurdur.setBounds(10, 90, 166, 43);
		contentPane.add(tglbtnBaslatDurdur);
		
		JToggleButton tglbtnSifirla = new JToggleButton("S\u0131f\u0131rla");
		tglbtnSifirla.setBounds(10, 144, 166, 43);
		contentPane.add(tglbtnSifirla);
		
		ActionListener is = new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				saniye++;
				if (saniye >59) {
					dakika++;
					saniye=0;					
				}
				if (dakika > 59) {
					saat++;
					dakika =0;
				}
				txtSaat.setText(saat+"");
				txtDakika.setText(dakika+"");
				txtSaniye.setText(saniye+"");
			}
		
		};
		t= new Timer(1,is );
	}
}