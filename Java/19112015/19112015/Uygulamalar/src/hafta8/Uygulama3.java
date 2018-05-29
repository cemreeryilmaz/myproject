package hafta8;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.Timer;
import javax.swing.border.EmptyBorder;
import javax.swing.JProgressBar;

import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JToggleButton;

public class Uygulama3 extends JFrame {

	private JPanel contentPane;
	private JProgressBar i�lem�ubu�u;
	Timer t;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Uygulama3 frame = new Uygulama3();
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
	public Uygulama3() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 394, 167);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final JToggleButton tglbtnBalatdurdur = new JToggleButton("Ba\u015Flat/Durdur");
		tglbtnBalatdurdur.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(tglbtnBalatdurdur.isSelected()){
					t.start();
					tglbtnBalatdurdur.setText("Durdur");
				}					
				else{
					t.stop();
					tglbtnBalatdurdur.setText("Ba�lat");
				}					
			}
		});
		tglbtnBalatdurdur.setBounds(39, 71, 313, 32);
		contentPane.add(tglbtnBalatdurdur);
		
		ActionListener i�=new ActionListener() {			
			public void actionPerformed(ActionEvent e) {
				i�lem�ubu�u.setValue(i�lem�ubu�u.getValue()+1);	
				if(i�lem�ubu�u.getValue()==i�lem�ubu�u.getMaximum()){
					t.stop();
					tglbtnBalatdurdur.setSelected(false);
					tglbtnBalatdurdur.setText("Ba�lat");
					i�lem�ubu�u.setValue(0);
				}					
			}
		};
		t=new Timer(100, i�);
		i�lem�ubu�u = new JProgressBar();
		i�lem�ubu�u.setToolTipText("\u0130\u015Flemin ne kadar\u0131n\u0131n yap\u0131ld\u0131\u011F\u0131n\u0131 g\u00F6sterir");
		i�lem�ubu�u.setForeground(Color.ORANGE);
		i�lem�ubu�u.setStringPainted(true);
		i�lem�ubu�u.setBounds(39, 28, 313, 32);
		contentPane.add(i�lem�ubu�u);
		
		
	}
}