namespace ZZZDmgCalculator.Models.Enum;

using System.Text.Json.Serialization;

/// <summary>
/// Stats enum, contains all the stats that can be modified by engines, skills, discs, etc.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Stats {
	// Base stats
	Atk,
	Hp,
	Def,
	Impact,
	CritRate,
	CritDmg,
	Pen,
	PenRatio,
	EnergyRegen,
	Proficiency,
	Mastery,
	
	// Bonus damage stats
	ElectricDmg = 25,
	EtherDmg,
	FireDmg,
	IceDmg,
	PhysicalDmg,
	
	// special anomaly stats, this stats are hidden by default unless theis value is not 0, these are increased by specific agents or skills.
	// for example jane core skill add physical anomaly crit rate and crit dmg.
	ElectricCritDmg = 50,
	EtherCritDmg,
	FireCritDmg,
	IceCritDmg,
	PhysicalCritDmg,
	ElectricCritRate,
	EtherCritRate,
	FireCritRate,
	IceCritRate,
	PhysicalCritRate,
	
	// special stats, these ones are also hidden by default, but they are increased by specific agents or skills.
	// also these stats can be modified for enemies.
	BonusDmg = 75,
	DmgTaken,
	DmgReduction,
	StunDmg
}