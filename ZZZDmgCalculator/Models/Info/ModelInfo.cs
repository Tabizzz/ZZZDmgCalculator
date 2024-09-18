namespace ZZZDmgCalculator.Models.Info;

public class ModelInfo {
	public required string UrlTemplate { get; set; }
	public Dictionary<string, double[]> Templates { get; set; } = [];
}

public class ModelInfo<T> : ModelInfo {
	public required List<T> Info { get; set; }
}