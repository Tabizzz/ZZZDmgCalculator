namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

/// <summary>
/// List of currently available discs in the game.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Discs
{
	ChaoticMetal,
	FangedMetal,
	FreedomBlues,
	HormonePunk,
	InfernoMetal,
	PolarMetal,
	PufferElectro,
	ShockstarDisco,
	SoulRock,
	SwingJazz,
	ThunderMetal,
	WoodpeckerElectro
}