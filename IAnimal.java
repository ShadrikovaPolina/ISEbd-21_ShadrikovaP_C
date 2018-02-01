import java.awt.Graphics;

public interface IAnimal {
	void moveAnimal();
	void drawAnimal(Graphics g);
	void setPosition(int x, int y);
	void eatFood(int count);
}
