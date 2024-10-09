namespace ZZZDmgCalculator.Models.State;

using Enum;
using Info;
using Enum=System.Enum;

public class AgentState {
	CoreSkills _coreSkillLevel;
	AscensionState _ascension;

	public AgentInfo Info { get; }

	public Agents Agent { get; }

	public AscensionState Ascension
	{
		get => _ascension;
		set
		{
			_ascension = value;
			UpdateBaseStats();
		}
	}

	public int Cinema { get; set; }

	public CoreSkills CoreSkillLevel
	{
		get => _coreSkillLevel;
		set
		{
			_coreSkillLevel = value;
			UpdateBaseStats();
		}
	}

	public EntityState Stats { get; } = new();

	/// <summary>
	/// The skill levels of the agent.
	/// 0: Basic Attack
	/// 1: Dodge
	/// 2: Assist
	/// 3: Special
	/// 4: Ultimate
	/// </summary>
	public int[] SkillLevels { get; private set; } = [1, 1, 1, 1, 1];

	public AgentState(AgentInfo info) {
		Info = info;
		Agent = Enum.Parse<Agents>(info.Id);
		UpdateBaseStats();
	}

	void UpdateBaseStats() {
		// reset all stat
		foreach (var stat in Enum.GetValues<Stats>())
		{
			Stats.Base[stat] = 0;
		}
		
		// Stats that scale with ascension
		Stats.Base[Models.Enum.Stats.Atk] = Info.BaseStats[0][(int)_ascension];
		Stats.Base[Models.Enum.Stats.Hp] =  Info.BaseStats[1][(int)_ascension];
		Stats.Base[Models.Enum.Stats.Def] = Info.BaseStats[2][(int)_ascension];
		
		// Fixed values for all agents
		Stats.Base[Models.Enum.Stats.CritDmg] = 50;
		Stats.Base[Models.Enum.Stats.CritRate] = 5;
		Stats.Base[Models.Enum.Stats.Pen] = 0;
		
		// Fixed values from info
		Stats.Base[Models.Enum.Stats.PenRatio] = Info.FinalStats[0];
		Stats.Base[Models.Enum.Stats.Impact] = Info.FinalStats[1];
		Stats.Base[Models.Enum.Stats.Mastery] = Info.FinalStats[2];
		Stats.Base[Models.Enum.Stats.Proficiency] = Info.FinalStats[3];
		Stats.Base[Models.Enum.Stats.EnergyRegen] = Info.FinalStats[4];

		// Core skill values
		var core1 = Info.CoreStats[0];
		var core2 = Info.CoreStats[1];
		CoreSkills[] coreSkillThresholds = [CoreSkills.A, CoreSkills.C, CoreSkills.E];
		foreach (var threshold in coreSkillThresholds)
		{
			if (_coreSkillLevel >= threshold)
			{
				Stats.Base[core1.Stat] += core1.Value;
			}
			if (_coreSkillLevel >= (threshold + 1))
			{
				Stats.Base[core2.Stat] += core2.Value;
			}
		}

		Stats.Update();
	}
}