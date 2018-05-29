package hafta4;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JSpinner;
import javax.swing.JLabel;
import javax.swing.SwingConstants;
import javax.swing.SpinnerNumberModel;
import javax.swing.SpinnerListModel;
import javax.swing.SpinnerDateModel;
import java.util.Date;
import java.util.Calendar;

public class Uygulama4 extends JFrame {

	private JPanel contentPane;

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
		setBounds(100, 100, 221, 204);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JSpinner spinner = new JSpinner();
		spinner.setModel(new SpinnerNumberModel(0, 0, 100, 5));
		spinner.setBounds(10, 27, 103, 30);
		contentPane.add(spinner);
		
		JLabel lblSay = new JLabel("Say\u0131");
		lblSay.setHorizontalAlignment(SwingConstants.CENTER);
		lblSay.setBounds(123, 27, 86, 30);
		contentPane.add(lblSay);
		
		JSpinner spinner_1 = new JSpinner();
		spinner_1.setModel(new SpinnerListModel(new String[] {"Ocak ", "\u015Eubat", "Mart", "Nisan ", "May\u0131s", "Haziran", "Temmuz", "A\u011Fustos", "Eyl\u00FCl", "Ekim", "Kas\u0131m", "Aral\u0131k"}));
		spinner_1.setBounds(10, 68, 103, 30);
		contentPane.add(spinner_1);
		
		JLabel lblListe = new JLabel("Liste");
		lblListe.setHorizontalAlignment(SwingConstants.CENTER);
		lblListe.setBounds(123, 68, 86, 30);
		contentPane.add(lblListe);
		
		JSpinner spinner_2 = new JSpinner();
		spinner_2.setModel(new SpinnerDateModel(new Date(1444856400000L), new Date(1444856400000L), new Date(1476478800000L), Calendar.DAY_OF_YEAR));
		spinner_2.setBounds(10, 111, 103, 30);
		contentPane.add(spinner_2);
		
		JLabel lblTarih = new JLabel("Tarih");
		lblTarih.setHorizontalAlignment(SwingConstants.CENTER);
		lblTarih.setBounds(123, 111, 86, 30);
		contentPane.add(lblTarih);
	}
}
