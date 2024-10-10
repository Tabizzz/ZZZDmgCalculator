namespace ZZZDmgCalculator.Services;

using Models.Enum;
using Models.State;

public class StateService {
	InfoService _info;
	
	int _currentAgentIndex;
	
	public SetupState CurrentSetup { get; set; } = new();

	public AgentState CurrentAgent
	{
		get => CurrentSetup.Agents[_currentAgentIndex]!;
		set => CurrentSetup.Agents[_currentAgentIndex] = value;
	}

	public AgentState?[] TeamAgents { get; private set; } = new AgentState[3];

	public StateService(InfoService info) {
		_info = info;
		// set ellen by default
		CurrentSetup.Agents[0] = new(_info[Agents.Rina]);
		_currentAgentIndex = 0;
	}
}