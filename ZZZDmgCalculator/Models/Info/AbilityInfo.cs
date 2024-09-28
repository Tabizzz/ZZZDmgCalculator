namespace ZZZDmgCalculator.Models.Info;

using Enum;

public class AbilityInfo : BaseInfo {
	public string Description { get; set; } = string.Empty;

	public Skills Category { get; set; }

	public double[][] Scales { get; set; } = [];

	public List<SkillInfo> Skills { get; set; } = [];

	public List<BuffInfo> Buffs { get; set; } = [];
}