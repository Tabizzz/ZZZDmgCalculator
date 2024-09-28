namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

/// <summary>
/// List of agents available in the game.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Agents {
	Rina,
	Nicole,
	Lucy,
	Soukaku,

	Anby,
	Koleda,
	Qingyi,
	Lycaon,

	Ben,
	Seth,

	Grace,
	Jane,
	Piper,

	Anton,
	Billy,
	Corin,
	Ellen,
	Nekomata,
	N11,
	ZhuYuan
}