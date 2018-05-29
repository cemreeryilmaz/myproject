package hafta4;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JSpinner;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.SpinnerDateModel;
import javax.swing.event.ChangeListener;
import javax.swing.event.ChangeEvent;

public class Uygulama5 extends JFrame {

	private JPanel contentPane;
	private JTextField txtG�n;
	private JTextField txtAy;
	private JTextField txtY�l;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama5 frame = new Uygulama5();
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
	public Uygulama5() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 257, 232);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final SpinnerDateModel tarihmodeli=new SpinnerDateModel();		
		
		JSpinner spnTarih = new JSpinner(tarihmodeli);
		spnTarih.addChangeListener(new ChangeListener() {
			public void stateChanged(ChangeEvent arg0) {
				txtG�n.setText(tarihmodeli.getDate().getDate()+"");
				txtAy.setText(tarihmodeli.getDate().getMonth()+1+"");
				txtY�l.setText(tarihmodeli.getDate().getYear()+1900+"");
			}
		});
		spnTarih.setBounds(12, 13, 154, 32);
		contentPane.add(spnTarih);
		
		JLabel lblTarih = new JLabel("Tarih");
		lblTarih.setBounds(182, 13, 90, 32);
		contentPane.add(lblTarih);
		
		txtG�n = new JTextField();
		txtG�n.setEditable(false);
		txtG�n.setBounds(12, 63, 154, 26);
		contentPane.add(txtG�n);
		txtG�n.setColumns(10);
		
		JLabel lblGn = new JLabel("G\u00FCn");
		lblGn.setBounds(181, 63, 77, 26);
		contentPane.add(lblGn);
		
		txtAy = new JTextField();
		txtAy.setEditable(false);
		txtAy.setColumns(10);
		txtAy.setBounds(12, 102, 154, 26);
		contentPane.add(txtAy);
		
		JLabel lblAy = new JLabel("Ay");
		lblAy.setBounds(181, 102, 77, 26);
		contentPane.add(lblAy);
		
		txtY�l = new JTextField();
		txtY�l.setEditable(false);
		txtY�l.setColumns(10);
		txtY�l.setBounds(12, 141, 154, 26);
		contentPane.add(txtY�l);
		
		JLabel lblYl = new JLabel("Y\u0131l");
		lblYl.setBounds(181, 141, 77, 26);
		contentPane.add(lblYl);
	}

}
