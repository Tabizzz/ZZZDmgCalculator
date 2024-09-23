namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ItemRank {
	B,
	A,
	S
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AgentRank {
	A,
	S
}