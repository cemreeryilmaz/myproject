package buttonlar;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JRadioButton;
import javax.swing.JLabel;
import javax.swing.SwingConstants;
import javax.swing.JComboBox;
import javax.swing.DefaultComboBoxModel;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Uygulama_2 extends JFrame {

	private JPanel contentPane;
	ButtonGrubu buttonGrubu = new ButtonGrubu();

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama_2 frame = new Uygulama_2();
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
	public Uygulama_2() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final JLabel lblRenk = new JLabel("Burada Renk G\u00F6sterilicek");
		lblRenk.setHorizontalAlignment(SwingConstants.CENTER);
		lblRenk.setBounds(200, 70, 199, 115);
		contentPane.add(lblRenk);
		lblRenk.setOpaque(true);
		
		final JRadioButton rdbtnBeyaz = new JRadioButton("Beyaz");
		rdbtnBeyaz.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (rdbtnBeyaz.isSelected()) {
					lblRenk.setBackground(Color.white);
					
				}
			}
		});
		buttonGrubu.add(rdbtnBeyaz);
		rdbtnBeyaz.setBounds(25, 66, 109, 23);
		contentPane.add(rdbtnBeyaz);
		
		final JRadioButton rdbtnKirmizi = new JRadioButton("K\u0131rm\u0131z\u0131");
		rdbtnKirmizi.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (rdbtnKirmizi.isSelected()) {
					lblRenk.setBackground(Color.red);
					
				}
			}
		});
		buttonGrubu.add(rdbtnKirmizi);
		rdbtnKirmizi.setBounds(25, 108, 109, 23);
		contentPane.add(rdbtnKirmizi);
		
		final JRadioButton rdbtnMavi = new JRadioButton("Mavi");
		rdbtnMavi.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (rdbtnMavi.isSelected()) {
					lblRenk.setBackground(Color.blue);
					
				}
			}
		});
		buttonGrubu.add(rdbtnMavi);
		rdbtnMavi.setBounds(25, 149, 109, 23);
		contentPane.add(rdbtnMavi);
		
		
		
		final JComboBox comboBox = new JComboBox();
		comboBox.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (comboBox.getSelectedIndex() == 0) {
					buttonGrubu.HepsiniAc();
				}
				else {
					buttonGrubu.HepsiniKapat();
				}
			}
		});
		comboBox.setModel(new DefaultComboBoxModel(new String[] {"Butonlar\u0131 A\u00E7", "Butonlar\u0131 Kapat"}));
		comboBox.setBounds(10, 11, 250, 35);
		contentPane.add(comboBox);
	}
}
