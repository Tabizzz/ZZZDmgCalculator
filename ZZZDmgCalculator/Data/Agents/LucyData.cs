namespace ZZZDmgCalculator.Data.Agents;

using Models.Enum;
using Models.Info;
using static AgentScales;

[UrlTemplate("icons/agents/Agent_{Icon}_Icon.webp")]
[InfoData<Agents>(Agents.Lucy)]
public class LucyData {
	public readonly static AgentInfo Data = new()
	{
		Id = nameof(Agents.Lucy),
		Icon = "Luciana_de_Montefio",
		Attribute = Attributes.Fire,
		Faction = Factions.Calydon,
		Specialty = Specialties.Support,
		AttackType = AttackTypes.Strike,
		DodgeType = DodgeTypes.Parry,
		AdditionalCondition = BasicAdditionalCondition,
		CoreStats =
		[
			new()
			{
				Stat = Stats.EnergyRegen,
				Value = 0.12
			},
			new()
			{
				Stat = Stats.Atk,
				Value = 25
			}
		],
		BaseStats =
		[
			Templates["Lucy.Atk"],
			Templates["Lucy.Hp"],
			Templates["Lucy.Def"],
		],
		FinalStats = [0, 86, 93, 94, 1.2],
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
						Scales = [56.6, 61.8, 67, 72.2, 77.4, 82.6, 87.8, 93, 98.2, 103.4, 108.6, 113.8, 119, 124.2, 129.4, 134.6]
					},
					new()
					{
						Type = Skills.Basic,
						DmgType = Attributes.Physical,
						Scales = [77.8, 84.9, 92.0, 99.1, 106.2, 113.3, 120.4, 127.5, 134.6, 141.7, 148.8, 155.9, 163.0, 170.1, 177.2, 184.3]
					},
					new()
					{
						Type = Skills.Basic,
						DmgType = Attributes.Physical,
						Scales = [188.9, 206.1, 223.3, 240.5, 257.7, 274.9, 292.1, 309.3, 326.5, 343.7, 360.9, 378.1, 395.3, 412.5, 429.7, 446.9]
					},
					new()
					{
						Type = Skills.Basic,
						DmgType = Attributes.Physical,
						Scales = [211.5, 230.8, 250.1, 269.4, 288.7, 308.0, 327.3, 346.6, 365.9, 385.2, 404.5, 423.8, 443.1, 462.4, 481.7, 501.0]
					},
					new()
					{
						Type = Skills.Basic,
						DmgType = Attributes.Fire,
						Scales = [272.6, 297.4, 322.2, 347.0, 371.8, 396.6, 421.4, 446.2, 471.0, 495.8, 520.6, 545.4, 570.2, 595, 619.8, 644.6]
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
						Scales = [92.5, 101, 109.5, 118, 126.5, 135, 143.5, 152, 160.5, 169, 177.5, 186, 194.5, 203, 211.5, 220]
					},
					new()
					{
						Type = Skills.Basic,
						DmgType = Attributes.Physical,
						Scales = [127.5, 139.1, 150.7, 162.3, 173.9, 185.5, 197.1, 208.7, 220.3, 231.9, 243.5, 255.1, 266.7, 278.3, 289.9, 301.5]
					},
					new()
					{
						Type = Skills.Basic,
						DmgType = Attributes.Physical,
						Scales = [175, 191, 207, 223, 239, 255, 271, 287, 303, 319, 335, 351, 367, 383, 399, 415]
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
						Scales = [78.4, 85.6, 92.8, 100.0, 107.2, 114.4, 121.6, 128.8, 136, 143.2, 150.4, 157.6, 164.8, 172.0, 179.2, 186.4]
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
						DmgType = Attributes.Fire,
						Scales = [308, 336, 364, 392, 420, 448, 476, 504, 532, 560, 588, 616, 644, 672, 700, 728]
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
						DmgType = Attributes.Fire,
						Scales = [60, 174.6, 189.2, 203.8, 218.4, 233.0, 247.6, 262.2, 276.8, 291.4, 306.0, 320.6, 335.2, 349.8, 364.4, 379.0]
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
						DmgType = Attributes.Fire,
						Scales = [349.1, 380.9, 412.7, 444.5, 476.3, 508.1, 539.9, 571.7, 603.5, 635.3, 667.1, 698.9, 730.7, 762.5, 794.3, 826.1]
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
						DmgType = Attributes.Fire,
						Scales = [61.7, 67.4, 73.1, 78.8, 84.5, 90.2, 95.9, 101.6, 107.3, 113.0, 118.7, 124.4, 130.1, 135.8, 141.5, 147.2]
					},
					new()
					{
						Type = Skills.Special,
						DmgType = Attributes.Fire,
						Scales = [69.2, 75.5, 81.8, 88.1, 94.4, 100.7, 107.0, 113.3, 119.6, 125.9, 132.2, 138.5, 144.8, 151.1, 157.4, 163.7]
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
						DmgType = Attributes.Fire,
						Scales = [508.4, 554.7, 601.0, 647.3, 693.6, 739.9, 786.2, 832.5, 878.8, 925.1, 971.4, 1017.7, 1064.0, 1110.3, 1156.6, 1202.9]
					},
					new()
					{
						Type = Skills.Ex,
						DmgType = Attributes.Fire,
						Scales = [536.4, 585.2, 634.0, 682.8, 731.6, 780.4, 829.2, 878.0, 926.8, 975.6, 1024.4, 1073.2, 1122.0, 1170.8, 1219.6, 1268.4]
					}
				],
				Buffs = new BuffInfo
				{
					BuffLimit = 600,
					Scales = [Templates["Lucy.b1"], Templates["Lucy.b2"]],
					Modifiers =
					[
						new() { Stat = Stats.Atk, Type = StatModifiers.BasePercent, Shared = true, Agent = true },
						new() { Stat = Stats.Atk, Type = StatModifiers.CombatFlat, Shared = true }
					]
				}
			},
			new()
			{
				Category = Skills.Ultimate,
				Skills =
				[
					new()
					{
						Type = Skills.Chain,
						DmgType = Attributes.Fire,
						Hits = 3,
						Scales = [164.1, 179.0, 194.0, 208.9, 223.8, 238.8, 253.7, 268.6, 283.5, 298.5, 313.4, 328.3, 343.3, 358.2, 373.1, 388.1]
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
						DmgType = Attributes.Fire,
						Hits = 3,
						Scales = [572.8, 624.9, 677, 729.1, 781.2, 833.3, 885.4, 937.5, 989.6, 1041.7, 1093.8, 1145.9, 1198.0, 1250.1, 1302.2, 1354.3]
					}
				]
			}
		],
		Cinema =
		{
			[4] = new StatModifier { Stat = Stats.CritDmg, Value = 10 },
			[6] = new SkillInfo { DmgType = Attributes.Fire, Value = 300 }
		}
	};
}