namespace ZZZDmgCalculator.Models.Info;

public class BaseInfo {
	
	public required string Id { get; set; }

	public string DisplayName { get; set; } = string.Empty;
	
	public string Icon { get; set; } = string.Empty;

	public string Url { get; set; } = string.Empty;
}