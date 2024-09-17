namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

/// <summary>
/// Available factions in the game.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Factions
{
	Belobog,
	Neps,
	Obol,
	Calydon,
	Victoria,
	Section6,
	Hares
}