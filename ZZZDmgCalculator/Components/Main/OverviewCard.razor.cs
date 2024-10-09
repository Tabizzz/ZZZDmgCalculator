namespace ZZZDmgCalculator.Components.Main;

using System.Collections;
using Models.Enum;
using Models.State;
using Radzen.Blazor;
using Util;

public partial class OverviewCard {
    static IEnumerable AscensionData => Enum.GetValues<AscensionState>();

	async Task OpenAgentDialog() {
		if (await Dialogs.OpenAgentDialog() is {} a)
		{
			State.CurrentAgent = new(Info[a]);
		}
	}
}