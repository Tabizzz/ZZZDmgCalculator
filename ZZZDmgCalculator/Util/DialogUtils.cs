namespace ZZZDmgCalculator.Util;

using Dialogs;
using Models.Enum;
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
}