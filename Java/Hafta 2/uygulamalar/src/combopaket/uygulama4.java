package combopaket;

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

public class uygulama4 extends JFrame {

	private JPanel contentPane;
	private JTextField metinAlanư;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					uygulama4 frame = new uygulama4();
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
	public uygulama4() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 490, 224);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final DefaultComboBoxModel<String> model = new DefaultComboBoxModel<String>();
		
		
		final JComboBox comboBox = new JComboBox(model);
		comboBox.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				metinAlanư.setText(model.getSelectedItem().toString());
			}
		});
		comboBox.setBounds(10, 31, 200, 27);
		contentPane.add(comboBox);
		
		metinAlanư = new JTextField();
		metinAlanư.setBounds(236, 34, 188, 27);
		contentPane.add(metinAlanư);
		metinAlanư.setColumns(10);
		
		JButton btnNewButton = new JButton("Ekle");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				String eklenecek = metinAlanư.getText();
				//model.addElement(eklenecek);
				model.insertElementAt(eklenecek, 0);
				comboBox.showPopup();
			}
		});
		btnNewButton.setBounds(264, 72, 145, 23);
		contentPane.add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("Sil");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if(model.getSize()>0){
				int index = comboBox.getSelectedIndex();
				model.removeElementAt(index);
				}
			}
		});
		btnNewButton_1.setBounds(264, 106, 145, 23);
		contentPane.add(btnNewButton_1);
		
		JButton btnNewButton_2 = new JButton("G\u00FCncelle");
		btnNewButton_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(model.getSize()>0){
					int index = comboBox.getSelectedIndex();
					model.removeElementAt(index);
					model.insertElementAt(metinAlanư.getText(), index);
					model.setSelectedItem(metinAlanư.getText());
					}
			}
		});
		btnNewButton_2.setBounds(264, 140, 145, 23);
		contentPane.add(btnNewButton_2);
	}
}
