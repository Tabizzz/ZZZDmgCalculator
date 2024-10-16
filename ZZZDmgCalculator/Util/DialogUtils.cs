namespace ZZZDmgCalculator.Util;

using Dialogs;
using Models.Enum;
using Models.Info;
using Models.State;
using Radzen;

public static class DialogUtils {
	public async static Task<Agents?> OpenAgentDialog(this DialogService dialogs) {
		object d = await dialogs.OpenAsync<ChooseAgentDialog>("AgentSelection", null, new()
		{
			Width = "950px",
			Height = "750px",
			ShowTitle = false,
			AutoFocusFirstElement = false,
			Style = "max-width: 100%"
		});
		return (Agents?)d;
	}
	
	public async static Task<EngineState?> OpenEngineDialog(this DialogService dialogs) {
		object d = await dialogs.OpenAsync<ChooseEngineDialog>("EngineSelection", null, new()
		{
			Width = "950px",
			Height = "750px",
			ShowTitle = false,
			AutoFocusFirstElement = false,
			Style = "max-width: 100%"
		});
		return (EngineState?)d;
	}
}