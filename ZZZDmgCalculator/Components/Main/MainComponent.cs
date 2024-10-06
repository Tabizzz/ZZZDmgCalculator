namespace ZZZDmgCalculator.Components.Main;

using System.Diagnostics.CodeAnalysis;
using MessagePipe;
using Microsoft.AspNetCore.Components;
using Services;

public abstract class MainComponent : ComponentBase, IDisposable {

	IDisposable _disposable = null!;

	[Inject]
	protected BrowserService Browser { get; private set; } = null!;

	[Inject]
	IAsyncSubscriber<BrowserDimension> ResizeSubscriber { get; set; } = null!;

	protected override async Task OnInitializedAsync() {
		var bag = DisposableBag.CreateBuilder();
		ResizeSubscriber.Subscribe(ResizeHandler).AddTo(bag);
		OnDisposableBag(bag);
		_disposable = bag.Build();

		await OnBrowserResizeAsync(await Browser.GetDimensionSafe());
	}

	[SuppressMessage("ReSharper", "MethodHasAsyncOverload")]
	async ValueTask ResizeHandler(BrowserDimension dimension, CancellationToken token) {
		OnBrowserResize(dimension);
		await OnBrowserResizeAsync(dimension);
	}

	protected virtual Task OnBrowserResizeAsync(BrowserDimension dimension) {
		
		return Task.CompletedTask;
	}
	
	protected virtual void OnBrowserResize(BrowserDimension dimension) {}

	protected virtual void OnDisposableBag(DisposableBagBuilder bag) {}

	public void Dispose() {
		_disposable.Dispose();
	}
}