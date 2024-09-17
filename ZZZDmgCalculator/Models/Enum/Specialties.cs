namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

/// <summary>
/// Available specialties in the game.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Specialties
{
	Attack,
	Defense,
	Support,
	Anomaly,
	Stun
}