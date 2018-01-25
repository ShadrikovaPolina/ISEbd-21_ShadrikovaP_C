import java.awt.Graphics;

import javax.swing.JPanel;

public class CrocodilePanel extends JPanel {
	private IAnimal inter;

	public void updatePanel(IAnimal inter) {
		this.inter = inter;
		repaint();
	}

	@Override
	public void paint(Graphics g) {
		super.paint(g);
		if (inter != null) {
			inter.drawAnimal(g);
		}
	}
}
