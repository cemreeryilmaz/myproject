package buttonlar;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.ImageIcon;
import javax.swing.JToggleButton;
import javax.swing.JLabel;
import javax.swing.SwingConstants;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Uygulama_4 extends JFrame {

	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama_4 frame = new Uygulama_4();
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
	public Uygulama_4() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 466);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final JLabel lblNewLabel = new JLabel("");
		lblNewLabel.setHorizontalAlignment(SwingConstants.CENTER);
		lblNewLabel.setBounds(10, 92, 207, 194);
		contentPane.add(lblNewLabel);
		
		final JToggleButton tglbtnNewToggleButton = new JToggleButton("A\u00E7 / Kapat");
		tglbtnNewToggleButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (tglbtnNewToggleButton.isSelected()) {
					tglbtnNewToggleButton.setText("Kapat");
					lblNewLabel.setIcon(new ImageIcon("C:\\Users\\Administrator\\Desktop\\A��k.jpg"));				
				}
				else {
					tglbtnNewToggleButton.setText("A�");
					lblNewLabel.setIcon(new ImageIcon("C:\\Users\\Administrator\\Desktop\\Kapal�.jpg"));
				}
				
				
			}
		});
		tglbtnNewToggleButton.setBounds(10, 31, 160, 38);
		contentPane.add(tglbtnNewToggleButton);
		
		
	}
}