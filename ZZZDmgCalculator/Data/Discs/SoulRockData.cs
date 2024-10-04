namespace ZZZDmgCalculator.Data.Discs;

using Models.Enum;
using Models.Info;
using Util;

[InfoData<Discs>(Discs.SoulRock)]
public class SoulRockData {
	public readonly static DiscInfo Data = new()
	{
		Id = nameof(Discs.SoulRock),
		StatBuff = new()
		{
			Stat = Stats.Def,
			Value = 16,
			Type = StatModifiers.BasePercent
		},
		Buffs = new BuffInfo()
		{
			Modifiers = new StatModifier
			{
				Stat = Stats.DmgReduction,
				Value = 40
			}
		}
	};
}