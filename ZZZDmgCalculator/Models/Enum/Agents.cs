namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

/// <summary>
/// List of agents available in the game.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Agents
{
	Rina,
	Anby,
	Anton,
	Ben,
	Billy,
	Corin,
	Ellen,
	Grace,
	Jane,
	Koleda,
	Nicole,
	Lucy,
	Nekomata,
	Piper,
	Qingyi,
	Seth,
	N11,
	Soukaku,
	Lycaon,
	ZhuYuan
}