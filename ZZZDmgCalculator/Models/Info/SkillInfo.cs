namespace ZZZDmgCalculator.Models.Info;

using Enum;

public class SkillInfo {
	public string DisplayName { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	
	public Stats Stat { get; set; }

	public bool Engine { get; set; }
	
	public Skills Type { get; set; }

	public double Value { get; set; }

	public string? Scale { get; set; }
}