import java.awt.EventQueue;

import javax.swing.JFrame;

import java.awt.*;
import javax.swing.JTextField;
import javax.swing.JCheckBox;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Form {

	private JFrame frame;
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;
	Color color;
	Color eyeColor;
	int maxSpeed;
	int maxCountFood;
	int weight;
	private IAnimal inter;
	JButton button;
	JButton button_1;

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
		initialize();
		color = new Color(0, 128, 0);
		eyeColor = Color.WHITE;
		maxSpeed = 20;
		maxCountFood = 10;
		weight = 50;
		button.setBackground(color);
		button_1.setBackground(eyeColor);
	}

	private void initialize() {
		frame = new JFrame();
		frame.setBackground(new Color(255, 204, 255));
		frame.setTitle("\u041B\u0430\u0431\u043E\u0440\u0430\u0442\u043E\u0440\u043D\u0430\u044F \u0440\u0430\u0431\u043E\u0442\u0430 \u21162");
		frame.setBounds(100, 100, 670, 460);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		CrocodilePanel panel = new CrocodilePanel();
		panel.setBackground(Color.WHITE);
		panel.setBounds(10, 11, 634, 278);
		frame.getContentPane().add(panel);

		textField = new JTextField();
		textField.setText("20");
		textField.setBounds(134, 300, 44, 20);
		frame.getContentPane().add(textField);
		textField.setColumns(10);

		textField_1 = new JTextField();
		textField_1.setText("10");
		textField_1.setColumns(10);
		textField_1.setBounds(134, 325, 44, 20);
		frame.getContentPane().add(textField_1);

		textField_2 = new JTextField();
		textField_2.setText("50");
		textField_2.setColumns(10);
		textField_2.setBounds(134, 350, 44, 20);
		frame.getContentPane().add(textField_2);

		JCheckBox chckbxNewCheckBox = new JCheckBox("\u0417\u0443\u0431\u044B");
		chckbxNewCheckBox.setBounds(10, 374, 97, 23);
		frame.getContentPane().add(chckbxNewCheckBox);

		JLabel lblNewLabel = new JLabel(
				"\u041C\u0430\u043A\u0441\u0438\u043C\u0430\u043B\u044C\u043D\u0430\u044F \u0441\u043A\u043E\u0440\u043E\u0441\u0442\u044C");
		lblNewLabel.setBounds(10, 303, 127, 14);
		frame.getContentPane().add(lblNewLabel);

		JLabel label = new JLabel("\u041A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u0435\u0434\u044B");
		label.setBounds(10, 328, 114, 14);
		frame.getContentPane().add(label);

		JLabel label_1 = new JLabel("\u041C\u0430\u0441\u0441\u0430");
		label_1.setBounds(10, 353, 46, 14);
		frame.getContentPane().add(label_1);

		JButton btnNewButton = new JButton("\u0414\u0432\u0438\u0436\u0435\u043D\u0438\u0435");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (inter != null)
	            {
	                inter.moveAnimal();
					panel.updatePanel(inter);
	            }
			}
		});
		btnNewButton.setBounds(213, 324, 97, 46);
		frame.getContentPane().add(btnNewButton);

		button = new JButton("\u041E\u0441\u043D\u043E\u0432\u043D\u043E\u0439 \u0446\u0432\u0435\u0442");
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				ColorDialog colorD = new ColorDialog(frame, true, color);
				colorD.setVisible(true);
				color = colorD.getColor();
				button.setBackground(color);
			}
		});
		button.setBounds(404, 299, 135, 23);
		frame.getContentPane().add(button);

		button_1 = new JButton("\u0426\u0432\u0435\u0442 \u0433\u043B\u0430\u0437");
		button_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				ColorDialog colorD = new ColorDialog(frame, true, eyeColor);
				colorD.setVisible(true);
				eyeColor = colorD.getColor();
				button_1.setBackground(eyeColor);
			}
		});
		button_1.setBounds(404, 324, 135, 23);
		frame.getContentPane().add(button_1);

		JButton button_2 = new JButton(
				"\u0417\u0430\u0434\u0430\u0442\u044C \u043A\u0440\u043E\u043A\u043E\u0434\u0438\u043B\u0430");
		button_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				eyeColor = Color.WHITE;
				button_1.setBackground(eyeColor);
				inter = new Crocodile(maxSpeed, maxCountFood, weight, color);
				panel.updatePanel(inter);
			}
		});
		button_2.setBounds(369, 349, 210, 23);
		frame.getContentPane().add(button_2);

		JButton button_3 = new JButton(
				"\u0417\u0430\u0434\u0430\u0442\u044C \u0430\u043B\u043B\u0438\u0433\u0430\u0442\u043E\u0440\u0430");
		button_3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (eyeColor == Color.WHITE) {
					eyeColor = Color.RED;
					button_1.setBackground(eyeColor);
				}
				inter = new Alligator(chckbxNewCheckBox.isSelected(), maxSpeed, maxCountFood,
						weight, color, eyeColor);
				panel.updatePanel(inter);
			}
		});
		button_3.setBounds(369, 374, 210, 23);
		frame.getContentPane().add(button_3);
	}
}
