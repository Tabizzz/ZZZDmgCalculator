namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AttackTypes {
	Slash,
	Strike,
	Pierce
}