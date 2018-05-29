package buttonlar;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.Timer;
import javax.swing.border.EmptyBorder;
import javax.swing.JToggleButton;
import javax.swing.JTextField;
import javax.swing.JLabel;

public class Uygulama_5 extends JFrame {

	private JPanel contentPane;
	private JTextField txtDakika;
	Timer t;
	int saniye = 0;
	int dakika = 0;
	private JTextField txtsaniye;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama_5 frame = new Uygulama_5();
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
	public Uygulama_5() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 495, 143);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final JToggleButton tglbtnNewToggleButton = new JToggleButton("Ba\u015Fla / Durdur");
		tglbtnNewToggleButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (tglbtnNewToggleButton.isSelected()) {
					t.start();
				}
				else {
					t.stop();
				}
			}
		});
		tglbtnNewToggleButton.setBounds(10, 22, 168, 54);
		contentPane.add(tglbtnNewToggleButton);
		
		txtDakika = new JTextField();
		txtDakika.setEditable(false);
		txtDakika.setBounds(188, 22, 108, 54);
		contentPane.add(txtDakika);
		txtDakika.setColumns(10);
		
		txtsaniye = new JTextField();
		txtsaniye.setEditable(false);
		txtsaniye.setBounds(309, 22, 108, 54);
		contentPane.add(txtsaniye);
		txtsaniye.setColumns(10);
		
		ActionListener i� = new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				saniye++;
				if (saniye==60) {
					saniye=0;
					dakika++;
				}
				
				txtDakika.setText(dakika+"");
				txtsaniye.setText(saniye+"");
			}
			
			
		};
		t = new Timer(100,i�);
		
			}

}