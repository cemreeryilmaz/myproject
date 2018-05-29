package hafta8;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.tree.DefaultMutableTreeNode;
import javax.swing.tree.DefaultTreeModel;
import javax.swing.JTree;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.event.TreeSelectionListener;
import javax.swing.event.TreeSelectionEvent;

public class Uygulama2 extends JFrame {

	private JPanel contentPane;
	private JTextField textField;
	DefaultMutableTreeNode se�ilen;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
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
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 375, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		DefaultMutableTreeNode k�k=new DefaultMutableTreeNode("Spor Dallar�");
		final DefaultTreeModel a�a�Modeli=new DefaultTreeModel(k�k);
		
		final JTree tree = new JTree(a�a�Modeli);
		tree.addTreeSelectionListener(new TreeSelectionListener() {
			public void valueChanged(TreeSelectionEvent arg0) {
				if(tree.getSelectionPath()!=null)
					
				se�ilen=(DefaultMutableTreeNode) 
				arg0.getNewLeadSelectionPath().getLastPathComponent();
			}
		});
		tree.setBounds(10, 24, 154, 227);
		contentPane.add(tree);
		
		textField = new JTextField();
		textField.setBounds(186, 24, 148, 28);
		contentPane.add(textField);
		textField.setColumns(10);
		
		JButton btnEkle = new JButton("Ekle");
		btnEkle.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if(se�ilen!=null){
					DefaultMutableTreeNode eklenecek=new DefaultMutableTreeNode(textField.getText());
					for (int i = 0; i < se�ilen.getChildCount(); i++) {
						if(eklenecek.toString().equals(se�ilen.getChildAt(i).toString()))
							return;
					}
				
				a�a�Modeli.insertNodeInto(eklenecek, se�ilen, 0);
				tree.updateUI();
				tree.expandRow(tree.getLeadSelectionRow());
				}
			}
		});
		btnEkle.setBounds(186, 63, 148, 28);
		contentPane.add(btnEkle);
		
		JButton btnSil = new JButton("Sil");
		btnSil.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if(!se�ilen.isRoot()){
				a�a�Modeli.removeNodeFromParent(se�ilen);
				}
			}
		});
		btnSil.setBounds(186, 102, 148, 28);
		contentPane.add(btnSil);
		
		JButton btnGncelle = new JButton("G\u00FCncelle");
		btnGncelle.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				int indis=tree.getLeadSelectionRow();
				DefaultMutableTreeNode ebeveyn=
				(DefaultMutableTreeNode) se�ilen.getParent();
				a�a�Modeli.removeNodeFromParent(se�ilen);
				a�a�Modeli.insertNodeInto(new DefaultMutableTreeNode
				(textField.getText()), ebeveyn, indis-1);	
				
			}
		});
		btnGncelle.setBounds(186, 141, 148, 28);
		contentPane.add(btnGncelle);
		
		JButton btnIsimDeitir = new JButton("\u0130sim De\u011Fi\u015Ftir");
		btnIsimDeitir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				se�ilen.setUserObject(textField.getText());
				tree.updateUI();
				tree.expandRow(tree.getLeadSelectionRow());
			}
		});
		btnIsimDeitir.setBounds(186, 180, 148, 28);
		contentPane.add(btnIsimDeitir);
	}
}
