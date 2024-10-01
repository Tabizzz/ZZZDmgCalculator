namespace ZZZDmgCalculator.Data.Discs;

using Models.Enum;
using Models.Info;

[InfoData<Discs>(Discs.WoodpeckerElectro)]
public class WoodpeckerElectroData {
	public readonly static DiscInfo Data = new()
	{
		Id = nameof(Discs.WoodpeckerElectro),
		StatBuff = new()
		{
			Stat = Stats.CritRate,
			Value = 8
		},
		FullSet = new()
		{
			Type = BuffTrigger.Stack,
			Stacks = 3,
			Modifiers = new StatModifier
			{
				Stat = Stats.Atk,
				Value = 9,
				Type = StatModifiers.CombatPercent
			}
		}
	};
}