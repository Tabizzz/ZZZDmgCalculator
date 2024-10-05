namespace ZZZDmgCalculator.Data.Discs;

using Models.Enum;
using Models.Info;

[InfoData<Discs>(Discs.ShockstarDisco)]
public class ShockstarDiscoData {
	public readonly static DiscInfo Data = new ()
	{
		Id = nameof(Discs.ShockstarDisco),
		StatBuff = new ()
		{
			Stat = Stats.Impact,
			Value = 6,
			Type = StatModifiers.BasePercent
		}
	};
}