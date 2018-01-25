import java.awt.*;

public abstract class Chordata implements IAnimal {
	protected int startPoseX;
	protected int startPoseY;
	protected int countFood;
	protected int maxCountFood;
	protected int maxSpeed;
	protected Color colorBody;
	protected double weight;

	public int getMaxCountFood() {
		return maxCountFood;
	}
	protected void setMaxCountFood(int maxCountFood) {
		this.maxCountFood = maxCountFood;
	}

	public int getMaxSpeed() {
		return maxSpeed;
	}
	protected void setMaxSpeed(int maxSpeed) {
		this.maxSpeed = maxSpeed;
	}

	public Color getColorBody() {
		return colorBody;
	}
	protected void setColorBody(Color color) {
		this.colorBody = color;
	}

	public double getWeight() {
		return weight;
	}
	protected void setWeight(double weight) {
		this.weight = weight;
	}

	public abstract void moveAnimal();
	public abstract void drawAnimal(Graphics g);

	public void setPosition(int x, int y) {
		startPoseX = x;
		startPoseY = y;
	}

	public void eatFood(int count) {
		if (countFood + count < maxCountFood) {
			countFood += count;
		}
	}
}
