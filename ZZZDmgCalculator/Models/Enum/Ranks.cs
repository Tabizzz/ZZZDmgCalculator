namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WeaponRank {
	S,
	A,
	B
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AgentRank {
	S,
	A
}