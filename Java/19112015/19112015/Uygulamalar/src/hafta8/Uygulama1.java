package hafta8;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTree;
import javax.swing.JScrollPane;
import javax.swing.tree.DefaultTreeModel;
import javax.swing.tree.DefaultMutableTreeNode;
import javax.swing.JTextField;
import javax.swing.JLabel;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JTextArea;

public class Uygulama1 extends JFrame {

	private JPanel contentPane;
	private JTextField txtD���mAd�;
	private JTextField txtEbeveyn;
	private JTextField txtK�k;
	private JTextField txtYaprak;
	private JTextArea txt�ocuk;

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
		setBounds(100, 100, 494, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 11, 137, 240);
		contentPane.add(scrollPane);
		
		final JTree a�a� = new JTree();
		a�a�.addMouseListener(new MouseAdapter() {
			@Override
			public void mousePressed(MouseEvent arg0) {
				DefaultMutableTreeNode d���m=(DefaultMutableTreeNode) 
				a�a�.getLeadSelectionPath().getLastPathComponent();
				txtD���mAd�.setText(d���m.toString());
				if(d���m.getParent()!=null)
				txtEbeveyn.setText(d���m.getParent().toString());
				else
				txtEbeveyn.setText("K�k �n ebeveyni olmaz");
				String �ocuklar="";
				for (int i = 0; i < d���m.getChildCount(); i++) {
					�ocuklar+=d���m.getChildAt(i).toString()+"\n";
				}
				txt�ocuk.setText(�ocuklar);
				if(d���m.isRoot()){
					txtK�k.setText("Se�ilen K�k t�r");
				}
				else{
					txtK�k.setText("Se�ilen K�k de�ildir");
				}
				if(d���m.isLeaf()){
					txtYaprak.setText("Se�ilen Yaprakt�r");
				}
				else{
					txtYaprak.setText("Se�ilen Yaprak De�ildir");
				}
			}
		});
		a�a�.setModel(new DefaultTreeModel(
			new DefaultMutableTreeNode("Spor Dallar\u0131") {
				{
					DefaultMutableTreeNode node_1;
					node_1 = new DefaultMutableTreeNode("Basketbol");
						node_1.add(new DefaultMutableTreeNode("Salon Basketbolu"));
						node_1.add(new DefaultMutableTreeNode("Sokak Basketbolu"));
					add(node_1);
					node_1 = new DefaultMutableTreeNode("Futbol");
						node_1.add(new DefaultMutableTreeNode("Amerikan Futbolu"));
						node_1.add(new DefaultMutableTreeNode("Rugby"));
						node_1.add(new DefaultMutableTreeNode("Avrupa Futbolu"));
					add(node_1);
					node_1 = new DefaultMutableTreeNode("Voleybol");
						node_1.add(new DefaultMutableTreeNode("Salon Voleybolu"));
						node_1.add(new DefaultMutableTreeNode("Plaj Voleybolu"));
					add(node_1);
					add(new DefaultMutableTreeNode("Tenis"));
					add(new DefaultMutableTreeNode("Y\u00FCzme"));
				}
			}
		));
		scrollPane.setViewportView(a�a�);
		
		txtD���mAd� = new JTextField();
		txtD���mAd�.setEditable(false);
		txtD���mAd�.setBounds(163, 21, 194, 26);
		contentPane.add(txtD���mAd�);
		txtD���mAd�.setColumns(10);
		
		JLabel lblDmAd = new JLabel("D\u00FC\u011F\u00FCm Ad\u0131");
		lblDmAd.setBounds(367, 21, 101, 26);
		contentPane.add(lblDmAd);
		
		txtEbeveyn = new JTextField();
		txtEbeveyn.setEditable(false);
		txtEbeveyn.setColumns(10);
		txtEbeveyn.setBounds(163, 58, 194, 26);
		contentPane.add(txtEbeveyn);
		
		JLabel lblEbeveyni = new JLabel("Ebeveyni");
		lblEbeveyni.setBounds(367, 58, 101, 26);
		contentPane.add(lblEbeveyni);
		
		JLabel lblocuklar = new JLabel("\u00C7ocuklar\u0131");
		lblocuklar.setBounds(367, 129, 101, 26);
		contentPane.add(lblocuklar);
		
		txtK�k = new JTextField();
		txtK�k.setEditable(false);
		txtK�k.setColumns(10);
		txtK�k.setBounds(163, 188, 194, 26);
		contentPane.add(txtK�k);
		
		JLabel lblKkM = new JLabel("K\u00F6k M\u00FC");
		lblKkM.setBounds(361, 188, 101, 26);
		contentPane.add(lblKkM);
		
		txtYaprak = new JTextField();
		txtYaprak.setEditable(false);
		txtYaprak.setColumns(10);
		txtYaprak.setBounds(163, 225, 194, 26);
		contentPane.add(txtYaprak);
		
		JLabel lblYaprakM = new JLabel("Yaprak M\u0131");
		lblYaprakM.setBounds(361, 225, 101, 26);
		contentPane.add(lblYaprakM);
		
		txt�ocuk = new JTextArea();
		txt�ocuk.setEditable(false);
		txt�ocuk.setBounds(163, 91, 194, 86);
		contentPane.add(txt�ocuk);
	}
}
