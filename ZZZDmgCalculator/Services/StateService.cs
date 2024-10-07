namespace ZZZDmgCalculator.Services;

using Models.Enum;
using Models.State;

public class StateService {
	InfoService _info;
	
	AgentState _currentAgent;
	int _currentAgentIndex;

	public AgentState CurrentAgent
	{
		get => _currentAgent;
		set
		{
			_currentAgent = value;
			TeamAgents[_currentAgentIndex] = value;
		}
	}

	public AgentState?[] TeamAgents { get; private set; } = new AgentState[3];

	public StateService(InfoService info) {
		_info = info;
		// set ellen by default
		_currentAgent = new(_info[Agents.Rina]);
		TeamAgents[0] = CurrentAgent;
		_currentAgentIndex = 0;
	}
}