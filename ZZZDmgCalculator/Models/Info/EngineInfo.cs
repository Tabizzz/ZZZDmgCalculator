namespace ZZZDmgCalculator.Models.Info;

using Enum;
using Services;

public class EngineInfo : BaseInfo {
	public required Specialties Type { get; set; }

	public required WeaponRank Rank { get; set; }

	public required StatModifier MainStat { get; set; }

	internal double[] MainStats { get; set; } = null!;

	public required string MainTemplate { get; set; }

	public required StatModifier SubStat { get; set; }

	internal double[] SubStats { get; set; } = null!;

	public required string SubTemplate { get; set; }

	public BuffInfo? Passive { get; set; }

	public List<BuffInfo> Passives { get; set; } = [];

	internal Dictionary<string, double[]> Scales { get; set; } = new();

	public Dictionary<string, string> ScaleTemplates { get; set; } = new();

	public SkillInfo? Skill { get; set; }

	public override void PostLoad(LangService lang, ModelInfo info) {
		MainStats = info.Templates[MainTemplate];
		SubStats = info.Templates[SubTemplate];
		foreach (var scaleTemplate in ScaleTemplates)
		{
			Scales[scaleTemplate.Key] = info.Templates[scaleTemplate.Value];
		}

		if (Passive != null)
		{
			Passives.Insert(0, Passive);
			Passive = null;
		}
		for (var i = 0; i < Passives.Count; i++)
		{
			var buffInfo = Passives[i];
			buffInfo.Id = $"Buffs.Engines.{Id}.{i}";
			buffInfo.DisplayName = lang[buffInfo.Id];
			buffInfo.Description = lang[$"{buffInfo.Id}.Desc"];
		}
		if (Skill == null) return;
		Skill.DisplayName = lang[$"Skills.Engines.{Id}"];
		Skill.Description = lang[$"Skills.Engines.{Id}.Desc"];
	}
}