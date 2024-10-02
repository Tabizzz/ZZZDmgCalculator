namespace ZZZDmgCalculator.Models.Info;

using System.Text.Json.Serialization;
using Enum;

public class AgentInfo : BaseInfo {

	public required Attributes Attribute { get; set; }

	public required Factions Faction { get; set; }

	public required Specialties Specialty { get; set; }

	public required AttackTypes AttackType { get; set; }

	public required DodgeTypes DodgeType { get; set; }

	[JsonIgnore]
	public required Func<AgentInfo, AgentInfo, bool> AdditionalCondition { get; set; }

	public required StatModifier[] CoreStats { get; set; }

	public required double[][] BaseStats { get; set; } = [];

	/// <summary>
	/// 0: Pen Ratio
	/// 1: Impact
	/// 2: Mastery
	/// 3: Proficiency
	/// 4: Energy
	/// </summary>
	public required double[] FinalStats { get; set; }

	public BuffInfo? CoreBuff { get; set; }

	public BuffInfo? AdditionalBuff { get; set; }

	public List<AbilityInfo> Abilities { get; set; } = [];

	public Dictionary<int, AbilityInfo> Cinema { get; set; } = new();
}