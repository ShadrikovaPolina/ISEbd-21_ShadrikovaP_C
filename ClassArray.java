import java.util.HashMap;

public class ClassArray<T> {
	private HashMap<Integer, T> places;
	private int maxCount;
	private T defaultValue;

	public ClassArray(int size, T defVal) {
		defaultValue = defVal;
		places = new HashMap<Integer, T>();
		maxCount = size;
	}

	public int add(T crocodile) {
		if (this.places.size() == this.maxCount) {
			return -1;
		}
		for (int i = 0; i < this.places.size(); i++) {
			if (this.checkFreePlace(i)) {
				this.places.put(i, crocodile);
				return i;
			}
		}
		this.places.put(this.places.size(), crocodile);
		return this.places.size() - 1;
	}

	private boolean checkFreePlace(int index) {
		return !places.containsKey(index);
	}

	public T dec(int index) {
		if (this.places.containsKey(index)) {
			T crocodile = this.getObject(index);
			this.places.remove(index);
			return crocodile;
		}
		return this.defaultValue;
	}

	public T getObject(int ind) {
		if (ind > -1 && ind < maxCount) {
			if (places.containsKey(ind))
				return places.get(ind);
		}
		return defaultValue;
	}
}
