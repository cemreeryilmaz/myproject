package uygulama1;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JComboBox;
import javax.swing.JTextField;
import javax.swing.JButton;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Uygulama1 extends JFrame {

	private JPanel contentPane;
	private JTextField metinAlanư;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama1 frame = new Uygulama1();
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
	public Uygulama1() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 448, 225);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final DefaultComboBoxModel<String> mod = new DefaultComboBoxModel<String>();
		
		final JComboBox comboBox = new JComboBox(mod);
		comboBox.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				metinAlanư.setText(mod.getSelectedItem().toString());
			}
		});
		comboBox.setBounds(10, 27, 177, 29);
		contentPane.add(comboBox);
		
		metinAlanư = new JTextField();
		metinAlanư.setBounds(203, 31, 177, 25);
		contentPane.add(metinAlanư);
		metinAlanư.setColumns(10);
		
		
		JButton btnNewButton = new JButton("Ekle");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				for (int i = 0; i < mod.getSize(); i++) {
					if(mod.getElementAt(i).toString().equals(metinAlanư.getText()))
					{
						return;
					}
					
					
				}
				mod.insertElementAt(metinAlanư.getText(), 0);
			}
		});
		btnNewButton.setBounds(223, 67, 143, 23);
		contentPane.add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("Sil");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(mod.getSize()>0){
					int index = comboBox.getSelectedIndex();
					mod.removeElementAt(index);
					}
			}
		});
		btnNewButton_1.setBounds(223, 101, 143, 23);
		contentPane.add(btnNewButton_1);
		
		JButton btnNewButton_2 = new JButton("G\u00FCncelle");
		btnNewButton_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(mod.getSize()>0){
					int index = comboBox.getSelectedIndex();
					mod.removeElementAt(index);
					mod.insertElementAt(metinAlanư.getText(), index);
					mod.setSelectedItem(metinAlanư.getText());
					}
			}
		});
		btnNewButton_2.setBounds(223, 138, 143, 23);
		contentPane.add(btnNewButton_2);
	}
}
