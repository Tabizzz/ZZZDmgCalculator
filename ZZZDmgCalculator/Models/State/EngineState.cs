namespace ZZZDmgCalculator.Models.State;

using Enum;
using Info;

public class EngineState(EngineInfo info) {

	AscensionState _ascension = AscensionState.A0_10;
	int _refinement = 1;

	public AscensionState Ascension
	{
		get => _ascension;
		set
		{
			Console.WriteLine($@"Ascencion changed to {value}");
			_ascension = value;
			Update();
		}
	}

	public int Refinement
	{
		get => _refinement;
		set
		{
			_refinement = Math.Clamp(value, 1, 5);
			Update(true);
		}
	}

	public StatModifier MainStat { get; } = info.MainStat.WithValue(info.MainStats[0]);

	public StatModifier SubStat { get; } = info.SubStat.WithValue(info.SubStats[0]);

	public List<BuffState> Buffs { get; } = info.Passives.Select(buff => new BuffState(buff){Buffs = GetInitialBuff(buff, info)}).ToList();

	static List<StatModifier> GetInitialBuff(BuffInfo buff, EngineInfo engineInfo) {
		var buffs = new List<StatModifier>();
		foreach (var statModifier in buff.BuffList)
		{
			if (buff.Scale is not null && statModifier.Value == 0)
			{
				// If the buff is scaling, we need to get the correct value from the scale.
				var scale = engineInfo.Scales[buff.Scale];
				var value = scale[0]; // 0 means the refinement is 1.
				buffs.Add(statModifier.WithValue(value));	
			}
			else
			{
				// If the buff is not scaling, we can just add it to the list.
				buffs.Add(statModifier.WithValue(statModifier.Value));
			}
		}
		return buffs;
	}

	List<StatModifier> _activePassives = [];
	
	public List<StatModifier> Passives => _activePassives;
	
	public void UpdateActivePassives() {
		_activePassives.Clear();
		Console.WriteLine(@"Updating active passives");
		foreach (var passive in Buffs.Where(passive => passive.Active))
		{
			if (passive.HasDependencies)
			{
				// If the passive has dependencies, we need to check if the dependency is active.
				var dependency = Buffs[passive.Info.Depends!.Value];
				if(!dependency.Active) continue;
				// If the dependency is active, we need to check if the dependency has the required stacks.
				if(dependency.Info.Type == BuffTrigger.Stack && dependency.Stacks < passive.Info.RequiredStacks) continue;
			}
			foreach (var buff in passive.Buffs)
			{
				_activePassives.Add(buff.WithValue(buff.Value * passive.ValueMultiplier));
			}
		}
	}
	
	void Update(bool refinement = false) {
		if (refinement)
		{
			foreach (var passive in Buffs.Where(passive => passive.IsScaling))
			{
				// if the buff is scaling, we need to get the correct value from the scale.
				for (var i = 0; i < passive.Buffs.Count; i++)
				{
					// check if the original modifier has value other than 0
					if(passive.Info.Buffs[i].Value != 0) continue;
					var buff = passive.Buffs[i];
					var scale = info.Scales[passive.Info.Scale!];
					var value = scale[_refinement - 1];// refinement - 1 is the index of the scale.
					buff.Value = value;
				}
			}
			UpdateActivePassives();
		}
		else
		{
			// the ascension has changed, we need to update the stats.
			MainStat.Value = info.MainStats[(int)_ascension];
			SubStat.Value = info.SubStats[(int)_ascension];
		}
	}
	
	public EngineInfo Info => info;
}