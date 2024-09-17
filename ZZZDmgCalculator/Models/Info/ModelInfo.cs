namespace ZZZDmgCalculator.Models.Info;

public class ModelInfo<T> {
	public required string UrlTemplate { get; set; }
	public required List<T> Info { get; set; }
}