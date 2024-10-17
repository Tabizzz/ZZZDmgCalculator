namespace ZZZDmgCalculator.Components;

using Microsoft.AspNetCore.Components;
using Services;

public class BrowserInterop : ComponentBase {
	
	[Inject]
	protected BrowserService BrowserService { get; set; } = null!;
	
	protected override async Task OnInitializedAsync() {
		await BrowserService.Init();
	}
}