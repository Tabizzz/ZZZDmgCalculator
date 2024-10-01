namespace ZZZDmgCalculator.Data;

using Models.Enum;
using Models.Info;

[UrlTemplate("icons/factions/{Icon}_Icon.webp")]
[InfoData<Factions>]
public static class FactionsData {
	public readonly static Dictionary<Factions, BaseInfo> Data = new()
	{
		[Factions.Belobog] = new()
		{
			Id = nameof(Factions.Belobog),
			Icon = "Belobog_Heavy_Industries",
		},
		[Factions.Neps] = new()
		{
			Id = nameof(Factions.Neps),
			Icon = "Criminal_Investigation_Special_Response_Team",
		},
		[Factions.Obol] = new()
		{
			Id = nameof(Factions.Obol),
			Icon = "Obol_Squad",
		},
		[Factions.Calydon] = new()
		{
			Id = nameof(Factions.Calydon),
			Icon = "Sons_of_Calydon",
		},
		[Factions.Victoria] = new()
		{
			Id = nameof(Factions.Victoria),
			Icon = "Victoria_Housekeeping",
		},
		[Factions.Section6] = new()
		{
			Id = nameof(Factions.Section6),
			Icon = "Section_6",
		},
		[Factions.Hares] = new()
		{
			Id = nameof(Factions.Hares),
			Icon = "Gentle_House",
		},
	};
}