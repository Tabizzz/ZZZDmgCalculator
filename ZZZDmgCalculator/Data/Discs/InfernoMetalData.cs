namespace ZZZDmgCalculator.Data.Discs;

using Models.Enum;
using Models.Info;

[InfoData<Discs>(Discs.InfernoMetal)]
public class InfernoMetalData {
	public readonly static DiscInfo Data = new()
	{
		Id = nameof(Discs.InfernoMetal),
		StatBuff = new()
		{
			Stat = Stats.FireDmg,
			Value = 10
		},
		FullSet = new()
		{
			Modifiers = new StatModifier
			{
				Stat = Stats.CritRate,
				Value = 28,
				Type = StatModifiers.Combat
			}
		}
	};
}