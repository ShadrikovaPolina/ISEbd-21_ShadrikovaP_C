import java.awt.*;

public class Alligator extends Crocodile {
	private Color eyeColor;
	private boolean tooth;

	public Alligator(boolean tooth, int maxSpeed, int maxCounFood, double weight,
			Color color, Color eyeColor) {
		super(maxSpeed, maxCounFood, weight, color);
		this.eyeColor = eyeColor;
		this.tooth = tooth;
	}

	@Override
	protected void drawCrocodile(Graphics g) {
		if (tooth) {
			g.setColor(Color.BLACK);
			g.drawOval(startPoseX + 134, startPoseY + 22, 5, 7);
			g.drawOval(startPoseX + 138, startPoseY + 22, 5, 7);
			g.drawOval(startPoseX + 142, startPoseY + 22, 5, 7);
			g.drawOval(startPoseX + 146, startPoseY + 22, 5, 7);
			g.drawOval(startPoseX + 150, startPoseY + 22, 5, 7);
			g.drawOval(startPoseX + 132, startPoseY + 14, 5, 7);
			g.drawOval(startPoseX + 136, startPoseY + 14, 5, 7);
			g.drawOval(startPoseX + 140, startPoseY + 14, 5, 7);
			g.drawOval(startPoseX + 144, startPoseY + 14, 5, 7);
			g.drawOval(startPoseX + 148, startPoseY + 14, 5, 7);
		}
		super.drawCrocodile(g);
		if (eyeColor != Color.WHITE) {
			g.setColor(eyeColor);
			g.fillOval(startPoseX + 121, startPoseY + 7, 6, 9);
			g.setColor(new Color(0, 0, 0));
			g.fillOval(startPoseX + 124, startPoseY + 10, 2, 3);
		}
	}
}
