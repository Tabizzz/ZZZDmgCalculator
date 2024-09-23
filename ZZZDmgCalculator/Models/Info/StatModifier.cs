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
	
	public bool IsCombatStat
	{
		get
		{
			if(Type == StatModifiers.Combat || Type == StatModifiers.CombatPercent || Type == StatModifiers.CombatFlat)
				return true;
			return Stat > Stats.BonusDmg;
		}
	}
	
	public bool IsPercent
	{
		get
		{
			if (Type is StatModifiers.CombatPercent or StatModifiers.BasePercent)
				return true;

			return Stat switch
			{
				Stats.CritRate => true,
				Stats.CritDmg => true,
				Stats.PenRatio => true,
				> Stats.ElectricDmg => true,
				_ => false
			};
		}
	}
}