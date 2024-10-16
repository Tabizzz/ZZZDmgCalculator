using Microsoft.AspNetCore.Components;

namespace ZZZDmgCalculator.Dialogs.Shared;

using Services;

public partial class ChooseDialogTitlebar {
	

	[Parameter]
	public string Title { get; set; } = "Choose";
	
	[Parameter]
	public RenderFragment? EnumFilters { get; set; }
	
	[Parameter]
	public int TitlebarThreshold { get; set; } = 535;
	
	[Parameter]
	public int FilterThreshold { get; set; } = 875;
	
	[Parameter]
	public string SearchFilter { get; set; } = string.Empty;
	
	[Parameter]
	public EventCallback<string> SearchFilterChanged { get; set; }
	
	bool _resPhone;
	int _resTitleState = 0;
	
	protected override void OnBrowserResize(BrowserDimension dimension) {
		base.OnBrowserResize(dimension);
		switch (_resPhone)
		{
			case false when dimension.Width < FilterThreshold:
				_resPhone = true;
				StateHasChanged();
				return;
			case true when dimension.Width > FilterThreshold:
				_resPhone = false;
				StateHasChanged();
				return;
		}

		StateHasChanged(ref _resTitleState, TitlebarThreshold);
	}
}