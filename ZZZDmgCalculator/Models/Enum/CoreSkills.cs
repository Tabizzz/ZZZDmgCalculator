namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

/// <summary>
/// Possible core skills states.
///
/// The <see cref="Empty"/> state is used when the core skills has 0 upgrades.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CoreSkills
{
	Empty,
	A,
	B,
	C,
	D,
	E,
	F
}