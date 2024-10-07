namespace ZZZDmgCalculator.Models.State;

using Enum;
using Info;
using Enum=System.Enum;

public class AgentState {

	public AgentInfo Info { get; }

	public Agents Agent { get; }

	public AscensionState Ascension { get; set; }

	public int Cinema { get; set; }

	public CoreSkills CoreSkillLevel { get; set; }

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
	}

}