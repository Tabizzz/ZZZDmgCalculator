namespace ZZZDmgCalculator.Data;

using Models.Enum;
using Models.Info;

[UrlTemplate("icons/skills/Icon_Core_Skill_{Id}.webp")]
[InfoData<CoreSkills>]
public static class CoreSkillsData {
	public readonly static Dictionary<CoreSkills, BaseInfo> Data = new()
	{
		[CoreSkills.Empty] = new()
		{
			Id = nameof(CoreSkills.Empty),
		},
		[CoreSkills.A] = new()
		{
			Id = nameof(CoreSkills.A),
		},
		[CoreSkills.B] = new()
		{
			Id = nameof(CoreSkills.B),
		},
		[CoreSkills.C] = new()
		{
			Id = nameof(CoreSkills.C),
		},
		[CoreSkills.D] = new()
		{
			Id = nameof(CoreSkills.D),
		},
		[CoreSkills.E] = new()
		{
			Id = nameof(CoreSkills.E),
		},
		[CoreSkills.F] = new()
		{
			Id = nameof(CoreSkills.F),
		},
	};
}