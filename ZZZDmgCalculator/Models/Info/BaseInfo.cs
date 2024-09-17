namespace ZZZDmgCalculator.Models.Info;

using Services;

public class BaseInfo {
	
	public required string Id { get; set; }

	public string DisplayName { get; set; } = string.Empty;
	
	public string Icon { get; set; } = string.Empty;

	public string Url { get; set; } = string.Empty;
	
	public virtual void PostLoad(LangService lang) { }
}