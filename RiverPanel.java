import java.awt.Graphics;

import javax.swing.JPanel;

public class RiverPanel extends JPanel {
	private River river;
	
	public RiverPanel(River aq){
		updateRiverPanel(aq);
	}
	
	public void updateRiverPanel(River aq){
		this.river=aq;
		repaint();
	}
	
	@Override
	public void paint(Graphics g) {
		super.paint(g);
		river.Draw(g);
	}
}
