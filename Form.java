import javax.swing.JFrame;

import java.awt.*;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.DefaultListModel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTextField;
import javax.swing.JList;
import javax.swing.border.LineBorder;

public class Form {

	private JFrame frame;
	Color color;
	Color eyeColor;
	int maxSpeed;
	int maxCountFood;
	int weight;
	private River river;
	private JTextField textField;
	JList<String> list;
	RiverPanel panel;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Form window = new Form();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Form() {
		river = new River(4);
		DefaultListModel<String> model = new DefaultListModel<String>();
		for (int i = 1; i < 5; i++) {
			model.addElement("Уровень " + i);
		}
		list = new JList<String>(model);
		list.setFont(new Font("Times New Roman", Font.PLAIN, 11));
		list.setSelectedIndex(river.GetCurrentLevel());
		initialize();
		color = new Color(0, 128, 0);
		eyeColor = Color.WHITE;
		maxSpeed = 20;
		maxCountFood = 10;
		weight = 50;
		Draw();
	}

	private void Draw() {
		if (list.getSelectedIndex() > -1) {
			panel.updateRiverPanel(river);
		}
	}

	private void initialize() {
		
		frame = new JFrame();
		frame.setBounds(100, 100, 900, 497);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JButton btnDown = new JButton("<<");
		btnDown.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				river.levelDown();
				list.setSelectedIndex(river.GetCurrentLevel());
				Draw();
			}
		});
		btnDown.setBounds(696, 118, 60, 38);
		frame.getContentPane().add(btnDown);

		JButton btnUp = new JButton(">>");
		btnUp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				river.levelUp();
				list.setSelectedIndex(river.GetCurrentLevel());
				Draw();
			}
		});
		btnUp.setBounds(796, 118, 60, 38);
		frame.getContentPane().add(btnUp);

		panel = new RiverPanel(river);
		panel.setBackground(Color.WHITE);
		panel.setBounds(10, 11, 660, 432);
		frame.getContentPane().add(panel);

		CrocodilePanel panel_1 = new CrocodilePanel();
		panel_1.setBackground(new Color(170, 220, 230));
		panel_1.setBounds(680, 279, 194, 131);
		frame.getContentPane().add(panel_1);

		JButton button_2 = new JButton(
				"\u0417\u0430\u0434\u0430\u0442\u044C \u043A\u0440\u043E\u043A\u043E\u0434\u0438\u043B\u0430");
		button_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				IAnimal inter = new Crocodile(maxSpeed, maxCountFood, weight, color);
				int place = river.PutAlligatorInRiver(inter);
				if (place > -1) {
					panel.updateRiverPanel(river);
					JOptionPane.showMessageDialog(null, "Ваше место: " + (place + 1), "",
							JOptionPane.INFORMATION_MESSAGE);
				} else {
					JOptionPane.showMessageDialog(null, "Мест нет", "", JOptionPane.INFORMATION_MESSAGE);
				}
			}
		});
		button_2.setBounds(696, 183, 160, 23);
		frame.getContentPane().add(button_2);

		JButton button_3 = new JButton(
				"\u0417\u0430\u0434\u0430\u0442\u044C \u0430\u043B\u043B\u0438\u0433\u0430\u0442\u043E\u0440\u0430");
		button_3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				IAnimal inter = new Alligator(true, maxSpeed, maxCountFood, weight, color, Color.RED);
				int place = river.PutAlligatorInRiver(inter);
				if (place > -1) {
					panel.updateRiverPanel(river);
					JOptionPane.showMessageDialog(null, "Ваше место: " + (place + 1), "",
							JOptionPane.INFORMATION_MESSAGE);
				} else {
					JOptionPane.showMessageDialog(null, "Мест нет", "", JOptionPane.INFORMATION_MESSAGE);
				}
			}
		});
		button_3.setBounds(696, 217, 160, 23);
		frame.getContentPane().add(button_3);

		JLabel label = new JLabel("\u041C\u0435\u0441\u0442\u043E");
		label.setBounds(789, 251, 46, 14);
		frame.getContentPane().add(label);

		JButton button = new JButton("\u0417\u0430\u0431\u0440\u0430\u0442\u044C");
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (textField.getText() != "") {
					IAnimal inter = river.GetAlligatorFromRiver(Integer.parseInt(textField.getText()) - 1);
					if (inter != null) {
						panel.updateRiverPanel(river);
						inter.setPosition(15, 35);
						panel_1.updatePanel(inter);
					} else {
						JOptionPane.showMessageDialog(null, "Место пустое", "", JOptionPane.INFORMATION_MESSAGE);
					}
				}
			}
		});
		button.setBounds(690, 247, 89, 23);
		frame.getContentPane().add(button);

		textField = new JTextField();
		textField.setText("1");
		textField.setBounds(828, 248, 46, 20);
		frame.getContentPane().add(textField);
		textField.setColumns(10);

		list.setBorder(new LineBorder(new Color(0, 0, 0)));
		list.setBounds(696, 11, 160, 96);
		frame.getContentPane().add(list);
	}
}
