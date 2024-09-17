namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

/// <summary>
/// Available skills in the game.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Skills
{
	Basic,
	Dodge,
	Assist,
	Special,
	Ultimate,
	
	Chain,
	Ex,
	// TODO: Add this entry to Skills.json
	Dash
}