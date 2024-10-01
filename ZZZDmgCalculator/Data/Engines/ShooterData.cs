namespace ZZZDmgCalculator.Data.Engines;

using Models.Enum;
using Models.Info;

[InfoData<Engines>(Engines.Shooter)]
public class ShooterData {
	public readonly static EngineInfo Data = new()
	{
		Id = nameof(Engines.Shooter),
		Icon = "Six_Shooter",
		Rank = ItemRank.A,
		Type = Specialties.Stun,  
		MainStat = new()
		{
			Stat = Stats.Atk
		},
		MainStats = EngineScales.Templates["GameBall.Main"],
		SubStat = new()
		{
			Stat = Stats.Impact,
			Type = StatModifiers.BasePercent
		},
		SubStats = EngineScales.Templates["Shooter.Sub"]
	};
}