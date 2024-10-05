namespace ZZZDmgCalculator.Data.Discs;

using Models.Enum;
using Models.Info;
using static Models.Enum.Discs;
using static Models.Enum.Stats;

[UrlTemplate("icons/discs/Drive_Disc_{Id_}_S.webp")]
[InfoData<Discs>(ChaoticMetal)]
public class ChaoticMetalData {
	public readonly static DiscInfo Data = new()
	{
		Id = nameof(ChaoticMetal),
		StatBuff = new()
		{
			Stat = EtherDmg,
			Value = 10
		},
		Buffs = new BuffInfo()
		{
			Modifiers = new StatModifier
			{
				Stat = DmgTaken,
				Enemy = true,
				Value = 18
			}
		}
	};
}