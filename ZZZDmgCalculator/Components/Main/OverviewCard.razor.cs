namespace ZZZDmgCalculator.Components.Main;

using System.Collections;
using Microsoft.AspNetCore.Components;
using Models.Enum;
using Models.State;
using Pages;
using Util;

public partial class OverviewCard {
    static IEnumerable AscensionData => Enum.GetValues<AscensionState>();
    
    [Parameter]
    public AgentState Agent { get; set; } = null!;
    
    [CascadingParameter]
    public Main MainPage { get; set; } = null!;
    
	async Task OpenAgentDialog() {
		if (await Dialogs.OpenAgentDialog() is {} a)
		{
			MainPage.AgentSwap(a);
		}
	}
}