namespace ZZZDmgCalculator.Components;

using MessagePipe;
using Microsoft.AspNetCore.Components;
using Services;

public partial class AdaptableCards : IDisposable {

	IDisposable _disposable = null!;

	int _pageWith;

	public int CardWith { get; private set; }

	public bool Phone { get; private set; }

	[Parameter]
	public RenderFragment ChildContent { get; set; } = null!;

	public readonly List<AdaptableCard> Cards = [];
	
	protected override async Task OnInitializedAsync() {
		_disposable = OnResize.Subscribe(OnResizeHandler);
		await OnResizeHandler(await Browser.GetDimensionSafe(), CancellationToken.None);
	}

	ValueTask OnResizeHandler(BrowserDimension dimension, CancellationToken token) {
		CardWith = dimension.Width switch
		{
			> 1920 => 450,
			< 1420 => 350,
			_ => (dimension.Width - 1420) * (450 - 350) / (1920 - 1420) + 350
		};

		Phone = dimension.Width < 576;

		StateHasChanged();
		Cards.ForEach(c=> c.Update());
		return ValueTask.CompletedTask;
	}

	public void Dispose() {
		_disposable.Dispose();
	}
}