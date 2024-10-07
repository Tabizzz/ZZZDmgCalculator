namespace ZZZDmgCalculator.Util;

using System.Collections;

public static class ListsUtil {

	public static IEnumerable Simple(int i, int i1) {
		var array = new int[i1-i+1];
		for (var j = 0; j < array.Length; j++) {
			array[j] = i + j;
		}
		return array;
	}
}