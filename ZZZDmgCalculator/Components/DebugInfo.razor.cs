namespace ZZZDmgCalculator.Components;

using Microsoft.AspNetCore.Components;
using Models.Info;

public partial class DebugInfo<TInfo>  where TInfo : BaseInfo {

	[Parameter]
	public IEnumerable<TInfo>? ItemList { get; set; }
}