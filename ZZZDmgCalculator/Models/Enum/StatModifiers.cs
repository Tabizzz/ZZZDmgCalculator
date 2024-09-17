namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

/// <summary>
/// List of all the possible stat modifiers.
///
/// A modifier means how the value is going to be modified by a operation following this formula:
/// <code>(Base*(1+(BasePercent/100))+BaseFlat)*(1+CombatPercent/100)+CombatFlat</code>
///
/// All modifiers of the same type are going to be added together and then applied to the formula.
///
/// Only the stats <see cref="Stats.Hp"/>, <see cref="Stats.Atk"/>, <see cref="Stats.EnergyRegen"/> and <see cref="Stats.Def"/> use
/// the full formula, the rest of stats use the <see cref="Base"/> and <see cref="Combat"/> modifier
/// only.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StatModifiers {
	/// <summary>
	/// Base modifier
	/// </summary>
	Base,
	BasePercent,
	BaseFlat,
	Combat,
	CombatPercent,
	CombatFlat,
}