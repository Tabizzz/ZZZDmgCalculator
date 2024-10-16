namespace ZZZDmgCalculator.Dialogs;

using Models.Enum;
using Models.Info;
using Util;

public partial class ChooseAgentDialog {
	string _searchFilter = string.Empty;
	readonly List<Attributes> _attributesFilter = [];
	readonly List<Specialties> _specialtiesFilter = [];
	readonly List<AgentRank> _rankFilter = [];
	
	
	IEnumerable<KeyValuePair<Agents, AgentInfo>> ApplyFilters(IEnumerable<KeyValuePair<Agents, AgentInfo>> infoAvailableAgents) => infoAvailableAgents
		.Where(i => i.Value.DisplayName.Contains(_searchFilter, StringComparison.CurrentCultureIgnoreCase))
		.Where(i => _attributesFilter.HasFilter(i.Value.Attribute) && _specialtiesFilter.HasFilter(i.Value.Specialty)
		                                                          && _rankFilter.HasFilter(i.Value.Rank))
		.Where(i => State.CurrentSetup.Agents.All(a => a?.Agent != i.Key));
}