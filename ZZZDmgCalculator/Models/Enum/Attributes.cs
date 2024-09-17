namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

/// <summary>
/// List of attributes that can be used in the game.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Attributes
{
	Fire,
	Ice,
	Physical,
	Electric,
	Ether
}