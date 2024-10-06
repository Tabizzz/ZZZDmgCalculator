namespace ZZZDmgCalculator.Models.State;

using Enum;
using Info;
using Enum=System.Enum;

public class AgentState {

	public AgentInfo Info { get; }
	
	public Agents Agent { get; }

	public AgentState(AgentInfo info) {
		Info = info;
		Agent = Enum.Parse<Agents>(info.Id);
	}

}