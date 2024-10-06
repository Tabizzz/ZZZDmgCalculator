namespace ZZZDmgCalculator.Components;

using Microsoft.AspNetCore.Components;

public partial class AdaptableCard {
	[CascadingParameter]
	public AdaptableCards? Parent { get; set; }

	[Parameter]
	public RenderFragment? ChildContent { get; set; }
	
	[Parameter]
	public string TabText { get; set; } = string.Empty;

	public string CardStyle => $"width: {Parent!.CardWith}px;";

	protected override void OnInitialized() {
		Parent?.Cards.Add(this);
	}

	public void Update() {
		StateHasChanged();
	}
}