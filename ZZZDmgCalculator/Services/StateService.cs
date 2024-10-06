namespace ZZZDmgCalculator.Services;

using Models.Enum;
using Models.State;

public class StateService {
	InfoService _info;

	public AgentState CurrentAgent { get; set; }

	public AgentState[] TeamAgents { get; private set; } = new AgentState[3];

	public StateService(InfoService info) {
		_info = info;
		// set ellen by default
		CurrentAgent = new(_info[Agents.Rina]);
		TeamAgents[0] = CurrentAgent;
	}
}