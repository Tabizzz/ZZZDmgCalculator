namespace ZZZDmgCalculator.Data.Agents;

using Models.Enum;
using Models.Info;

[InfoData<Agents>(Agents.Nicole)]
public class NicoleData {
	public readonly static AgentInfo Data = new()
	{
		Id = nameof(Agents.Nicole),
		Icon = "Nicole_Demara",
		Attribute = Attributes.Ether,
		Faction = Factions.Hares,
		Specialty = Specialties.Support,
		AttackType = AttackTypes.Strike,
		DodgeType = DodgeTypes.Parry,
		CoreStats =
		[
			new()
			{
				Stat = Stats.EnergyRegen, Value = 0.12
			},
			new()
			{
				Stat = Stats.Atk, Value = 25
			}
		],
		BaseStats =
		[
			AgentScales.Templates["Nicole.Atk"],
			AgentScales.Templates["Nicole.Hp"],
			AgentScales.Templates["Nicole.Def"],
		],
		FinalStats = [0, 88, 93, 99, 1.2],
		CoreBuff = new()
		{
			Scales = [[-20, -25, -30, -34, -36, -38, -40]],
			Modifiers = new StatModifier
			{
				Stat = Stats.Def, Type = StatModifiers.CombatPercent, Enemy = true
			}
		},
		AdditionalBuff = new StatModifier
		{
			Stat = Stats.EtherDmg, Type = StatModifiers.Combat, Shared = true, Value = 25
		},
		Abilities =
		[
			new()
			{
				Category = Skills.Basic,
				Skills =
				[
					new()
					{
						Type = Skills.Basic,
						DmgType = Attributes.Physical,
						Ticks = 4,
						Scales = [65.9, 71.9, 77.9, 83.9, 89.9, 95.9, 101.9, 107.9, 113.9, 119.9, 125.9, 131.9, 137.9, 143.9, 149.9, 155.9]
					},
					new()
					{
						Type = Skills.Basic,
						DmgType = Attributes.Physical,
						Ticks = 5,
						Scales = [71.3, 77.8, 84.3, 90.8, 97.3, 103.8, 110.3, 116.8, 123.3, 129.8, 136.3, 142.8, 149.3, 155.8, 162.3, 168.8]
					},
					new()
					{
						Type = Skills.Basic,
						DmgType = Attributes.Physical,
						Ticks = 21,
						Scales = [304.3, 331.6, 358.9, 386.2, 413.5, 440.8, 468.1, 495.4, 522.7, 550.0, 577.3, 604.6, 631.9, 659.2, 686.5, 713.8]
					}
				]
			},
			new()
			{
				Category = Skills.Basic,
				Skills =
				[
					new()
					{
						Type = Skills.Basic,
						DmgType = Attributes.Physical,
						Ticks = 4,
						Scales = [88.1, 96.2, 104.3, 112.4, 120.5, 128.6, 136.7, 144.8, 152.9, 161.0, 169.1, 177.2, 185.3, 193.4, 201.5, 209.6]
					},
					new()
					{
						Type = Skills.Basic,
						DmgType = Attributes.Physical,
						Ticks = 5,
						Scales = [100.9, 110.2, 119.5, 128.8, 138.1, 147.4, 156.7, 166.0, 175.3, 184.6, 193.9, 203.2, 212.5, 221.8, 231.1, 240.4]
					},
					new()
					{
						Type = Skills.Basic,
						DmgType = Attributes.Physical,
						Ticks = 21,
						Scales = [452.3, 493.6, 534.9, 576.2, 617.5, 658.8, 700.1, 741.4, 782.7, 824.0, 865.3, 906.6, 947.9, 989.2, 1030.5, 1071.8]
					}
				]
			},
			new()
			{
				Category = Skills.Dodge,
				Skills =
				[
					new()
					{
						Type = Skills.Dash,
						DmgType = Attributes.Physical,
						Ticks = 14,
						Scales = [158.2, 172.4, 186.6, 200.8, 215.0, 229.2, 243.4, 257.6, 271.8, 286.0, 300.2, 314.4, 328.6, 342.8, 357.0, 371.2]
					},
					new()
					{
						Type = Skills.Dash,
						DmgType = Attributes.Physical,
						Scales = [60, 65.5, 71, 76.5, 82, 87.5, 93, 98.5, 104, 109.5, 115, 120.5, 126, 131.5, 137, 142.5]
					}
				]
			},
			new()
			{
				Category = Skills.Dodge,
				Skills =
				[
					new()
					{
						Type = Skills.Dodge,
						DmgType = Attributes.Ether,
						Ticks = 14,
						Scales = [182.4, 199, 215.6, 232.2, 248.8, 265.4, 282, 298.6, 315.2, 331.8, 348.4, 365, 381.6, 398.2, 414.8, 431.4]
					}
				]
			},
			new()
			{
				Category = Skills.Assist,
				Skills =
				[
					new()
					{
						Type = Skills.Assist,
						DmgType = Attributes.Ether,
						Scales = [63.4, 69.2, 75, 80.8, 86.6, 92.4, 98.2, 104, 109.8, 115.6, 121.4, 127.2, 133, 138.8, 144.6, 150.4]
					}
				]
			},
			new()
			{
				Category = Skills.Assist,
				Skills =
				[
					new()
					{
						Type = Skills.Assist,
						DmgType = Attributes.Ether,
						Scales = [377.1, 411.4, 445.7, 480, 514.3, 548.6, 582.9, 617.2, 651.5, 685.8, 720.1, 754.4, 788.7, 823, 857.3, 891.6]
					}
				]
			},
			new()
			{
				Category = Skills.Special,
				Skills =
				[
					new()
					{
						Type = Skills.Special,
						DmgType = Attributes.Ether,
						Scales = [50, 52.4, 54.8, 57.2, 59.6, 62, 64.4, 66.8, 69.2, 71.6, 74, 76.4, 78.8, 81.2, 83.6, 86]
					}
				]
			},
			new()
			{
				Category = Skills.Special,
				Skills =
				[
					new()
					{
						Type = Skills.Ex,
						DmgType = Attributes.Ether,
						Scales = [215, 234.6, 254.2, 273.8, 293.4, 313, 332.6, 352.2, 371.8, 391.4, 411, 430.6, 450.2, 469.8, 489.4, 509]
					},
					new()
					{
						Type = Skills.Ex,
						DmgType = Attributes.Ether,
						Scales = [215, 234.6, 254.2, 273.8, 293.4, 313, 332.6, 352.2, 371.8, 391.4, 411, 430.6, 450.2, 469.8, 489.4, 509]
					},
					new()
					{
						Type = Skills.Ex,
						DmgType = Attributes.Ether,
						Scales = [387, 422.2, 457.4, 492.6, 527.8, 563.0, 598.2, 633.4, 668.6, 703.8, 739.0, 774.2, 809.4, 844.6, 879.8, 915.0]
					}
				]
			},
			new()
			{
				Category = Skills.Ultimate,
				Skills =
				[
					new()
					{
						Type = Skills.Chain,
						DmgType = Attributes.Ether,
						Scales = [209.6, 228.8, 248, 267.2, 286.4, 305.6, 324.8, 344, 363.2, 382.4, 401.6, 420.8, 440, 459.2, 478.4, 497.6]
					},
					new()
					{
						Type = Skills.Chain,
						DmgType = Attributes.Ether,
						Scales = [283, 308.8, 334.6, 360.4, 386.2, 412, 437.8, 463.6, 489.4, 515.2, 541, 566.8, 592.6, 618.4, 644.2, 670]
					}
				]
			},
			new()
			{
				Category = Skills.Ultimate,
				Skills =
				[
					new()
					{
						Type = Skills.Ultimate,
						DmgType = Attributes.Ether,
						Scales = [646.8, 705.6, 764.4, 823.2, 882, 940.8, 999.6, 1058.4, 1117.2, 1176, 1234.8, 1293.6, 1352.4, 1411.2, 1470, 1528.8]
					},
					new()
					{
						Type = Skills.Ultimate,
						DmgType = Attributes.Ether,
						Scales = [873.2, 952.6, 1032, 1111.4, 1190.8, 1270.2, 1349.6, 1429, 1508.4, 1587.8, 1667.2, 1746.6, 1826, 1905.4, 1984.8, 2064.2]
					}
				]
			}
		],
		Cinema =
		{
			[1] = new BuffInfo
			{
				Type = BuffTrigger.Permanent,
				SkillCondition = skill => skill.Type == Skills.Ex,
				Modifiers = new StatModifier
				{
					Stat = Stats.BonusDmg, Value = 16
				}
			},
			[6] = new BuffInfo
			{
				Type = BuffTrigger.Stack,
				Stacks = 10,
				Modifiers = new StatModifier { Stat = Stats.CritRate, Value = 1.5, Type = StatModifiers.Combat, Shared = true }
			}
		}
	};
}