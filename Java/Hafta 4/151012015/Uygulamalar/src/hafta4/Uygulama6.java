package hafta4;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JSpinner;
import javax.swing.JToggleButton;
import javax.swing.JTextField;

public class Uygulama6 extends JFrame {

	private JPanel contentPane;
	private JTextField textField;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama6 frame = new Uygulama6();
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
	public Uygulama6() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 186, 176);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JSpinner spinner = new JSpinner();
		spinner.setBounds(23, 13, 128, 26);
		contentPane.add(spinner);
		
		JToggleButton tglbtnNewToggleButton = new JToggleButton("Ba\u015Fla/Durdur");
		tglbtnNewToggleButton.setBounds(23, 57, 128, 25);
		contentPane.add(tglbtnNewToggleButton);
		
		textField = new JTextField();
		textField.setEditable(false);
		textField.setBounds(23, 95, 128, 26);
		contentPane.add(textField);
		textField.setColumns(10);
	}
}
