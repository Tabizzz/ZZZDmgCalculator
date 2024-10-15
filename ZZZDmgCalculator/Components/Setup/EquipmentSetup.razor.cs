namespace ZZZDmgCalculator.Components.Setup;

using Microsoft.AspNetCore.Components;
using Models.State;

public partial class EquipmentSetup {
	[Parameter]
	public AgentState Agent { get; set; } = null!;

	int _equipmentSelectedIndex = 0;
}