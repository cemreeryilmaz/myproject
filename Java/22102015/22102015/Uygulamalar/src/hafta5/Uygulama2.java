package hafta5;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.UIManager;
import javax.swing.border.EmptyBorder;
import javax.swing.JList;
import javax.swing.JButton;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

import javax.swing.AbstractListModel;
import javax.swing.border.BevelBorder;
import javax.swing.border.LineBorder;
import javax.swing.plaf.nimbus.NimbusLookAndFeel;

import java.awt.Color;

import org.eclipse.wb.swing.FocusTraversalOnArray;

import java.awt.Component;
import java.awt.event.ComponentAdapter;
import java.awt.event.ComponentEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.ListSelectionModel;
import javax.swing.AbstractAction;
import javax.swing.Action;

public class Uygulama2 extends JFrame {

	private JPanel contentPane;
	private JButton btnNewButton;
	private final Action action = new SwingAction();

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					UIManager.setLookAndFeel(new NimbusLookAndFeel());
					Uygulama2 frame = new Uygulama2();
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
	public Uygulama2() {
		addMouseListener(new MouseAdapter() {
			@Override
			public void mousePressed(MouseEvent arg0) {
			}
		});
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 409, 270);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JList list = new JList();
		list.setModel(new AbstractListModel() {
			String[] values = new String[] {"Ahmet", "Mehmet", "Seda", "Elif"};
			public int getSize() {
				return values.length;
			}
			public Object getElementAt(int index) {
				return values[index];
			}
		});
		list.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		list.setBounds(24, 34, 103, 170);
		contentPane.add(list);
		
		JList list_1 = new JList();
		list_1.setToolTipText("Merhaba");
		list_1.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		list_1.setBounds(237, 34, 103, 170);
		contentPane.add(list_1);
		
		btnNewButton = new JButton(">>");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		btnNewButton.setBounds(137, 56, 89, 23);
		contentPane.add(btnNewButton);
		
		JButton button = new JButton("<<");
		button.setBounds(137, 90, 89, 23);
		contentPane.add(button);
		
		JButton button_1 = new JButton("-------->");
		button_1.setBounds(137, 124, 89, 23);
		contentPane.add(button_1);
		
		JButton button_2 = new JButton("<--------");
		button_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				SwingAction act=new SwingAction();
				act.actionPerformed(e);
			}
		});
		button_2.setAction(action);
		button_2.setBounds(137, 158, 89, 23);
		contentPane.add(button_2);
		setFocusTraversalPolicy(new FocusTraversalOnArray(new Component[]{btnNewButton, button, list, list_1, button_1, button_2, contentPane}));
	}

	private class SwingAction extends AbstractAction {
		public SwingAction() {
			putValue(NAME, "SwingAction");
			putValue(SHORT_DESCRIPTION, "Some short description");
		}
		public void actionPerformed(ActionEvent e) {
			
		}
	}
}
