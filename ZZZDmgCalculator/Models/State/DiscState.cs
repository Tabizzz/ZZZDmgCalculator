namespace ZZZDmgCalculator.Models.State;

using Enum;
using Info;
using Enum=System.Enum;

public class DiscState {
	const int MaxSubStats = 4;

	readonly DiscStatInfo _mainStat;
	readonly List<DiscStatInfo?> _subStats = new(MaxSubStats);
	readonly int[] _subStatsRolls = new int[MaxSubStats];

	public Discs Disc { get; }

	public DiscInfo Info { get; }

	/// <summary>
	/// From 0 to 15.
	/// </summary>
	public int Level { get; set; } = 0;

	public ItemRank Rank { get; set; } = ItemRank.S;

	public Stats MainStat => _mainStat.Buff.Stat;
	
	public int SubStatCount => _subStats.Count;

	public DiscState(DiscInfo info, DiscStatInfo mainStat) {
		_mainStat = mainStat;
		Info = info;
		Disc = Enum.Parse<Discs>(info.Id);
	}

	public void SetSubStat(DiscStatInfo subStat, int rolls) {
		var index = _subStats.IndexOf(subStat);
		if (index >= 0)
		{
			_subStatsRolls[index] = rolls;
		}
		else if (_subStats.Count < MaxSubStats)
		{
			_subStatsRolls[_subStats.Count] = rolls;
			_subStats.Add(subStat);
		}
		else
		{
			throw new InvalidOperationException("Cannot add more sub stats.");
		}
	}
}