namespace ZZZDmgCalculator.Components;

using MessagePipe;
using Microsoft.AspNetCore.Components;
using Services;

public partial class AdaptableCards {
	
	int _pageWith;

	public int CardWith { get; private set; }

	public bool Phone { get; private set; }

	[Parameter]
	public RenderFragment ChildContent { get; set; } = null!;
	
	protected override void OnBrowserResize(BrowserDimension dimension) {
		CardWith = dimension.Width switch
		{
			> 1920 => 450,
			< 1420 => 400,
			_ => (dimension.Width - 1420) * (450 - 400) / (1920 - 1420) + 400
		};

		Phone = dimension.Width < 576;

		StateHasChanged(); 
	}
}