namespace ZZZDmgCalculator.Util;

public class SingleList <T> : List<T> {
	public static implicit operator SingleList <T>(T d) => [d];
}