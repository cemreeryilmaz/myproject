package sorular;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.text.MaskFormatter;
import javax.swing.JFormattedTextField;
import javax.swing.JTextField;
import javax.swing.JButton;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class soru_2 extends JFrame {

	private JPanel contentPane;
	private JTextField textField;
	private JTextField textField_1;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					soru_2 frame = new soru_2();
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
	public soru_2() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		MaskFormatter bankano = new MaskFormatter("####"-"####"-"####"-"####");
		
		JFormattedTextField formattedTextField = new JFormattedTextField(bankano);
		formattedTextField.setBounds(10, 21, 211, 29);
		contentPane.add(formattedTextField);
		
		
		
		textField = new JTextField();
		textField.setBounds(10, 68, 211, 29);
		contentPane.add(textField);
		textField.setColumns(10);
		
		JButton btnGiriYap = new JButton("Giri\u015F Yap");
		btnGiriYap.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
			}
		});
		btnGiriYap.setBounds(10, 108, 200, 39);
		contentPane.add(btnGiriYap);
		
		textField_1 = new JTextField();
		textField_1.setEditable(false);
		textField_1.setBounds(10, 154, 211, 39);
		contentPane.add(textField_1);
		textField_1.setColumns(10);
	}
}
