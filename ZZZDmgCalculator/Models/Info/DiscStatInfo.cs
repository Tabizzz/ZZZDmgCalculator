namespace ZZZDmgCalculator.Models.Info;

public class DiscStatInfo {

	public int[]? MainDiscs { get; set; }

	public double[][]? MainScales { get; set; }

	public double[]? SubScales { get; set; }

	public required StatModifier Buff { get; set; }
}