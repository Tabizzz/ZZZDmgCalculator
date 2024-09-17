namespace ZZZDmgCalculator.Models.Info;

using Enum;

public class BuffInfo {
	public string DisplayName { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	
	public BuffTrigger Type { get; set; }
	/// <summary>
	/// Only used when <see cref="Type"/> is <see cref="BuffTrigger.Stack"/>.
	/// </summary>
	public int Stacks { get; set; }

	public List<StatModifier> Buffs { get; set; } = [];
	
	public StatModifier? Buff { get; set; }
}