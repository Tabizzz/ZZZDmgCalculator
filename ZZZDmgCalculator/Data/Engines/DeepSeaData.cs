namespace ZZZDmgCalculator.Data.Engines;

using Models.Enum;
using Models.Info;
using static EngineScales;
using static Models.Enum.BuffTrigger;
using static Models.Enum.Engines;
using static Models.Enum.ItemRank;
using static Models.Enum.Specialties;
using static Models.Enum.StatModifiers;
using static Models.Enum.Stats;

[UrlTemplate("icons/engines/W-Engine_{Icon}.webp")]
[InfoData<Engines>(DeepSea)]
public class DeepSeaData {
	public readonly static EngineInfo Data = new()
	{
		Id = nameof(DeepSea),
		Icon = "Deep_Sea_Visitor",
		Rank = S,
		Type = Attack,
		MainStat = new()
		{
			Stat = Atk
		},
		MainStats = Templates["Stinger.Main"],
		SubStat = new()
		{
			Stat = CritRate
		},
		SubStats = Templates["Cradle.Sub"],
		Passives = [
			new()
			{
				Scales = [Templates["Cushion.Buff1"]],
				Type = Permanent,
				Modifiers = new StatModifier
				{
					Stat = IceDmg,
					Type = Combat
				}
			},
			new()
			{
				Scales = [Templates["Cradle.Buff2"]],
				Modifiers = new StatModifier
				{
					Stat = CritRate,
					Type = Combat
				}
			},
			new()
			{
				Scales = [Templates["Cradle.Buff2"]],
				Modifiers = new StatModifier
				{
					Stat = CritRate,
					Type = Combat
				}
			}
		]
	};
}