namespace ZZZDmgCalculator.Models.Info;

public class ModelInfo {
	public string UrlTemplate { get; set; } = string.Empty;
	public Dictionary<string, double[]> Templates { get; set; } = [];
}

public class ModelInfo<T> : ModelInfo {
	public required List<T> Info { get; set; }
}