namespace ZZZDmgCalculator.Data.Discs;

using Models.Enum;
using Models.Info;

[InfoData<Discs>(Discs.FangedMetal)]
public class FangedMetalData {
	public readonly static DiscInfo Data = new()
	{
		Id = nameof(Discs.FangedMetal),
		StatBuff = new()
		{
			Stat = Stats.PhysicalDmg,
			Value = 10
		},
		// I dont know if the full set is a bonus damage buff for agent or a dmg taken debuff for enemy.
		// I am assuming it is a dmg taken debuff for enemy but it need more deep testing.
		FullSet = new()
		{
			Modifiers = new StatModifier
			{
				Stat = Stats.DmgTaken,
				Enemy = true,
				Value = 35
			}
		}
	};
}