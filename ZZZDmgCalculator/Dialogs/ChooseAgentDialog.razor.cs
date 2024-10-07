namespace ZZZDmgCalculator.Dialogs;

using Models.Enum;
using Models.Info;
using Services;
using Util;

public partial class ChooseAgentDialog {
	string _searchFilter = string.Empty;
	readonly List<Attributes> _attributesFilter = [];
	readonly List<Specialties> _specialtiesFilter = [];
	readonly List<AgentRank> _rankFilter = [];
	const int ResLimit = 875;
	bool _resPhone;
	int _resAgentSelection = 0;
	protected override void OnBrowserResize(BrowserDimension dimension) {
		base.OnBrowserResize(dimension);
		switch (_resPhone)
		{
			case false when dimension.Width < ResLimit:
				_resPhone = true;
				StateHasChanged();
				return;
			case true when dimension.Width > ResLimit:
				_resPhone = false;
				StateHasChanged();
				return;
		}

		StateHasChanged(ref _resAgentSelection, 535);
	}
	IEnumerable<KeyValuePair<Agents, AgentInfo>> ApplyFilters(IEnumerable<KeyValuePair<Agents, AgentInfo>> infoAvailableAgents) => infoAvailableAgents
		.Where(i => i.Value.DisplayName.Contains(_searchFilter, StringComparison.CurrentCultureIgnoreCase))
		.Where(i => _attributesFilter.HasFilter(i.Value.Attribute) && _specialtiesFilter.HasFilter(i.Value.Specialty)
		                                                          && _rankFilter.HasFilter(i.Value.Rank))
		.Where(i => State.TeamAgents.All(a => a?.Agent != i.Key));
}