namespace ZZZDmgCalculator.Data.Agents;

using Models.Enum;
using Models.Info;

public static class AgentScales {
	public readonly static Dictionary<string, double[]> Templates = new()
	{
		["Rina.Atk"] = [103, 157, 194, 254, 291, 351, 388, 448, 484, 544, 581, 642],
		["Rina.Hp"] = [692, 1537, 2012, 2951, 3426, 4366, 4841, 5780, 6255, 7194, 7669, 8609],
		["Rina.Def"] = [48, 106, 139, 205, 238, 304, 337, 402, 436, 502, 535, 600],
		
		["Nicole.Atk"] = [93, 140, 173, 227, 261, 314, 347, 400, 433, 486, 520, 574],
		["Nicole.Hp"] = [655, 1454, 1903, 2792, 3242, 4131, 4580, 5469, 5919, 6808, 7257, 8145],
		["Nicole.Def"] = [50, 111, 145, 213, 248, 315, 349, 417, 451, 519, 554, 622],
		
		["Lucy.Atk"] = [95, 143, 177, 232, 266, 320, 354, 408, 441, 495, 529, 583],
		["Lucy.Hp"] = [645, 1433, 1876, 2751, 3194, 4070, 4514, 5389, 5832, 6708, 7150, 8025],
		["Lucy.Def"] = [49, 109, 143, 210, 244, 310, 343, 410, 444, 511, 545, 612],
		["Lucy.b1"] = [13.8, 14.6, 15.4, 16.2, 17.0, 17.8, 18.6, 19.4, 20.2, 21.0, 21.8, 22.6, 23.4, 24.2, 25.0, 25.8],
		["Lucy.b2"] = [44, 48, 52, 56, 60, 64, 68, 72, 76, 80, 84, 88, 92, 96, 100, 104]
	};
	
	public static bool BasicAdditionalCondition(AgentInfo agent, AgentInfo target) => agent.Attribute == target.Attribute || agent.Faction == target.Faction;
}