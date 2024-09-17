namespace ZZZDmgCalculator.Models.Info;

public class DiscInfo : BaseInfo {
	public required StatModifier StatBuff { get; set; }

	public BuffInfo? FullSet { get; set; }

	public List<BuffInfo> FullSets { get; set; } = [];
	
	public string? Condition { get; set; }
}