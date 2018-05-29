package buttonlar;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JRadioButton;
import javax.swing.JLabel;
import javax.swing.SwingConstants;
import java.awt.Color;
import javax.swing.ButtonGroup;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Uygulama_1 extends JFrame {

	private JPanel contentPane;
	private final ButtonGroup buttonGroup = new ButtonGroup();

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama_1 frame = new Uygulama_1();
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
	public Uygulama_1() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final JLabel lblrenk = new JLabel("Renk Burda G\u00F6sterilicek");
		lblrenk.setBackground(Color.CYAN);
		lblrenk.setHorizontalAlignment(SwingConstants.CENTER);
		lblrenk.setBounds(207, 36, 186, 127);
		contentPane.add(lblrenk);
		lblrenk.setOpaque(true);
		
		final JRadioButton rdbtnkirmizi = new JRadioButton("K\u0131rm\u0131z\u0131");
		rdbtnkirmizi.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (rdbtnkirmizi.isSelected()) {
					lblrenk.setBackground(Color.RED);
			}
			}
		});
		buttonGroup.add(rdbtnkirmizi);
		rdbtnkirmizi.setBounds(31, 52, 109, 23);
		contentPane.add(rdbtnkirmizi);
		
		
		
		final JRadioButton rdbtnsari = new JRadioButton("Sar\u0131");
		rdbtnsari.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (rdbtnsari.isSelected()) {
					lblrenk.setBackground(Color.YELLOW);
			}
			}
		});
		buttonGroup.add(rdbtnsari);
		rdbtnsari.setBounds(31, 106, 109, 23);
		contentPane.add(rdbtnsari);
		
		final JRadioButton rdbtnsiyah = new JRadioButton("Siyah");
		rdbtnsiyah.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (rdbtnsiyah.isSelected()) {
					lblrenk.setBackground(Color.BLACK);
				}
				
			}
		});
		buttonGroup.add(rdbtnsiyah);
		rdbtnsiyah.setBounds(31, 155, 109, 23);
		contentPane.add(rdbtnsiyah);
	}
}


