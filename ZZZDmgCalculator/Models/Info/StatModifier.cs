namespace ZZZDmgCalculator.Models.Info;

using Enum;

public class StatModifier {
	public required Stats Stat { get; set; }
	public double Value { get; set; }
	public StatModifiers Type { get; set; }
	/// <summary>
	/// If true, the modifier will be applied to the enemy.
	/// </summary>
	public bool Enemy { get; set; }
	/// <summary>
	/// If true, the modifier will be applied to the entire team and not just the owner.
	/// </summary>
	public bool Shared { get; set; }
	
	public StatModifier WithValue(double value) => new()
	{
		Stat = Stat,
		Value = value,
		Type = Type,
		Enemy = Enemy,
		Shared = Shared
	};
}