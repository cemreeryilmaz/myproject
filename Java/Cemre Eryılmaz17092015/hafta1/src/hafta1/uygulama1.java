package hafta1;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class uygulama1 extends JFrame {

	private JPanel contentPane;
	private JTextField txt1;
	private JTextField txt2;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					uygulama1 frame = new uygulama1();
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
	public uygulama1() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		txt1 = new JTextField();
		txt1.setBounds(10, 22, 267, 20);
		contentPane.add(txt1);
		txt1.setColumns(10);
		
		JButton btnBuyuk = new JButton("BUYUK");
		btnBuyuk.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				txt2.setText(txt1.getText().toUpperCase());
			}
		});
		btnBuyuk.setBounds(10, 61, 119, 45);
		contentPane.add(btnBuyuk);
		
		JButton btnKucuk = new JButton("K\u00DC\u00C7\u00DCK");
		btnKucuk.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				txt2.setText(txt1.getText().toLowerCase());
			}
		});
		btnKucuk.setBounds(158, 61, 119, 45);
		contentPane.add(btnKucuk);
		
		txt2 = new JTextField();
		txt2.setEditable(false);
		txt2.setBounds(10, 127, 267, 20);
		contentPane.add(txt2);
		txt2.setColumns(10);
	}
}
