namespace ZZZDmgCalculator.Models.Info;

using Services;

public class DiscInfo : BaseInfo {
	public required StatModifier StatBuff { get; set; }

	public BuffInfo? FullSet { get; set; }
	public List<BuffInfo> FullSets { get; set; } = [];

	public string? Condition { get; set; }

	public override void PostLoad(LangService lang, ModelInfo info) {
		if (FullSet != null)
		{
			FullSets.Insert(0, FullSet);
			FullSet = null;
		}
		for (var i = 0; i < FullSets.Count; i++)
		{
			var buffInfo = FullSets[i];
			buffInfo.Id = $"Buffs.Engines.{Id}.{i}";
			buffInfo.DisplayName = lang[buffInfo.Id];
			buffInfo.Description = lang[$"{buffInfo.Id}.Desc"];
		}
	}
}