import java.awt.*;
import java.util.Random;

public class Crocodile extends Chordata {

	@Override
	protected void setMaxCountFood(int value) {
		if (value > 0 && value < 16) {
			super.setMaxCountFood(value);
		} else {
			super.setMaxCountFood(15);
		}
	}

	@Override
	protected void setMaxSpeed(int value) {
		super.setMaxSpeed(maxSpeed);
		if (value > 0 && value < 31) {
			super.setMaxSpeed(value);
		} else {
			super.setMaxSpeed(30);
		}
	}

	@Override
	protected void setWeight(double value) {
		if (value > 10 && value < 800) {
			super.setWeight(value);
		} else {
			super.setWeight(800);
		}
	}

	public Crocodile(int maxSpeed, int maxCountFood, double weight, Color color) {
		this.weight = weight;
		this.maxSpeed = maxSpeed;
		this.maxCountFood = maxCountFood;
		this.colorBody = color;
		this.countFood = 0;
		Random rand = new Random();
		startPoseX = rand.nextInt(90) + 10;
		startPoseY = rand.nextInt(40) + 60;
	}

	@Override
	public void moveAnimal() {
		startPoseX += (maxSpeed * 20 / (float) weight) / (countFood == 0 ? 1 : countFood);
	}

	@Override
	public void drawAnimal(Graphics g) {
		drawCrocodile(g);
	}

	protected void drawCrocodile(Graphics g) {
		g.setColor(colorBody);
		g.fillArc(startPoseX - 10, startPoseY + 10, 70, 30, 160, -200);
		g.fillOval(startPoseX + 40, startPoseY + 4, 85, 35);
		g.fillOval(startPoseX + 113, startPoseY + 6, 25, 25);
		g.fillOval(startPoseX + 115, startPoseY + 14, 45, 7);
		g.fillOval(startPoseX + 115, startPoseY + 23, 45, 7);
		g.fillOval(startPoseX + 55, startPoseY + 30, 12, 20);
		g.fillOval(startPoseX + 95, startPoseY + 30, 12, 20);
		g.fillOval(startPoseX + 152, startPoseY + 12, 7, 6);
		g.setColor(new Color(0, 64, 0));
		g.fillOval(startPoseX + 154, startPoseY + 14, 3, 3);
		g.setColor(new Color(255, 255, 255));
		g.fillOval(startPoseX + 121, startPoseY + 7, 6, 9);
		g.setColor(new Color(0, 0, 0));
		g.fillOval(startPoseX + 124, startPoseY + 10, 2, 3);
	}
}
