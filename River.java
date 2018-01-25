import java.awt.Color;
import java.awt.Graphics;

public class River {
	ClassArray<IAnimal> river;
	int countPlaces = 8;
	int placeSizeWidth = 300;
	int placeSizeHeight = 80;

	public River() {
		river = new ClassArray<IAnimal>(countPlaces, null);
	}

	public int PutAlligatorInRiver(IAnimal crocodile) {
		return river.add(river, crocodile);
	}

	public IAnimal GetAlligatorFromRiver(int index) {
		return river.dec(river, index);
	}

	public void Draw(Graphics g) {
		drawRiver(g);
		for (int i = 0; i < countPlaces; i++) {
			IAnimal crocodile = river.getObject(i);
			if (crocodile != null) {
				crocodile.setPosition(50 + i / 4 * (placeSizeWidth + 10) + 5, i % 4 * (placeSizeHeight + 20) + 45);
				crocodile.drawAnimal(g);
			}
		}
	}

	private void drawRiver(Graphics g) {
		for (int i = 0; i < countPlaces / 4; i++) {
			for (int j = 0; j < 4; j++) {
				g.setColor(new Color(170, 220, 230));
				g.fillRect(10 * (i + 1) + i * placeSizeWidth, 20 * (j + 1) + j * placeSizeHeight, placeSizeWidth,
						placeSizeHeight);
				g.setColor(Color.BLACK);
				g.drawRect(10 * (i + 1) + i * placeSizeWidth, 20 * (j + 1) + j * placeSizeHeight, placeSizeWidth,
						placeSizeHeight);
			}
		}
	}
}
