namespace ZZZDmgCalculator.Data.Discs;

using Models.Enum;
using Models.Info;

[InfoData<Discs>(Discs.ThunderMetal)]
public class ThunderMetalData {
	public readonly static DiscInfo Data = new()
	{
		Id = nameof(Discs.ThunderMetal),
		StatBuff = new()
		{
			Stat = Stats.ElectricDmg,
			Value = 10
		},
		Buffs = new BuffInfo
		{
			Modifiers = new StatModifier
			{
				Stat = Stats.Atk,
				Value = 27,
				Type = StatModifiers.CombatPercent
			}
		}
	};
}