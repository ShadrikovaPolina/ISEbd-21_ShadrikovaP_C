import java.awt.Color;
import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;

public class River {
	List<ClassArray<IAnimal>> river;
	int countPlaces = 8;
	int placeSizeWidth = 300;
	int placeSizeHeight = 80;
	int currentLevel;

	public River(int countLevels) {
		river = new ArrayList<ClassArray<IAnimal>>();
		for (int i = 0; i < countLevels; i++) {
			river.add(new ClassArray<IAnimal>(countPlaces, null));
		}
		currentLevel = 0;
	}

	public int GetCurrentLevel() {
		return currentLevel;
	}

	public void levelUp() {
		if (currentLevel + 1 < river.size()) {
			currentLevel++;
		}
	}

	public void levelDown() {
		if (currentLevel > 0) {
			currentLevel--;
		}
	}

	public int PutAlligatorInRiver(IAnimal crocodile) {
		return river.get(currentLevel).add(crocodile);
	}

	public IAnimal GetAlligatorFromRiver(int index) {
		return river.get(currentLevel).dec(index);
	}

	public void Draw(Graphics g) {
		drawRiver(g);
		for (int i = 0; i < countPlaces; i++) {
			IAnimal crocodile = river.get(currentLevel).getObject(i);
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
