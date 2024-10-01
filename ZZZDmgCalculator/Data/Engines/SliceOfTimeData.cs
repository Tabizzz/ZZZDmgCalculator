namespace ZZZDmgCalculator.Data.Engines;

using Models.Enum;
using Models.Info;

[InfoData<Engines>(Engines.SliceOfTime)]
public class SliceOfTimeData {
	public readonly static EngineInfo Data = new()
	{
		Id = nameof(Engines.SliceOfTime),
		Icon = "Slice_of_Time",
		Rank = ItemRank.A,
		Type = Specialties.Support,
		MainStat = new()
		{
			Stat = Stats.Atk
		},
		MainStats = EngineScales.Templates["GameBall.Main"],
		SubStat = new()
		{
			Stat = Stats.PenRatio
		},
		SubStats = EngineScales.Templates["SliceOfTime.Sub"]
	};
}