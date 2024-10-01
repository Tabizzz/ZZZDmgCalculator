namespace ZZZDmgCalculator.Data.Discs;

using Models.Enum;
using Models.Info;

[InfoData<Discs>(Discs.FreedomBlues)]
public class FreedomBluesData {
	public readonly static DiscInfo Data = new()
	{
		Id = nameof(Discs.FreedomBlues),
		StatBuff = new()
		{
			Stat = Stats.Proficiency,
			Value = 30,
			Type = StatModifiers.CombatFlat
		}
	};
}