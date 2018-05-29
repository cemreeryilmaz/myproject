package combopaket;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JComboBox;
import javax.swing.JTextField;
import javax.swing.DefaultComboBoxModel;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;

public class uygulama3 extends JFrame {

	private JPanel contentPane;
	private JTextField metinAlanı;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					uygulama3 frame = new uygulama3();
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
	public uygulama3() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 386, 165);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final JComboBox comboBox = new JComboBox();
		comboBox.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				metinAlanı.setText(comboBox.getSelectedItem().toString());
				
			}
		});
		comboBox.setModel(new DefaultComboBoxModel(Günler.values()));
		comboBox.setBounds(10, 30, 160, 20);
		contentPane.add(comboBox);
		
		metinAlanı = new JTextField();
		metinAlanı.setEditable(false);
		metinAlanı.setBounds(201, 30, 145, 20);
		contentPane.add(metinAlanı);
		metinAlanı.setColumns(10);
	}

}
