namespace ZZZDmgCalculator.Services;

using System.Diagnostics;
using System.Net.Http.Json;
using Config;
using Helper;
using Models.Enum;
using Models.Info;

/// <summary>
/// Load and manages info about the models.
/// </summary>
public class InfoService(HttpClient http, LangService lang) {

	Dictionary<Factions, BaseInfo> _factions = null!;
	public BaseInfo this[Factions item] => _factions[item];

	Dictionary<Specialties, BaseInfo> _specialties = null!;
	public BaseInfo this[Specialties item] => _specialties[item];

	Dictionary<Skills, BaseInfo> _skills = null!;
	public BaseInfo this[Skills item] => _skills[item];

	Dictionary<CoreSkills, BaseInfo> _coreSkills = null!;
	public BaseInfo this[CoreSkills item] => _coreSkills[item];

	Dictionary<Attributes, BaseInfo> _attributes = null!;
	public BaseInfo this[Attributes item] => _attributes[item];

	Dictionary<Discs, DiscInfo> _discs = null!;
	public DiscInfo this[Discs item] => _discs[item];
	
	Dictionary<Engines, EngineInfo> _engines = null!;
	public EngineInfo this[Engines item] => _engines[item];
	
	Dictionary<Stats, StatInfo> _stats = null!;
	public StatInfo this[Stats item] => _stats[item];

	public async Task LoadAll() {
		_factions = await Load<Factions, BaseInfo>(Paths.FactionsInfoUrl);
		_specialties = await Load<Specialties, BaseInfo>(Paths.SpecialtiesInfoUrl);
		_skills = await Load<Skills, BaseInfo>(Paths.SkillsInfoUrl);
		_coreSkills = await Load<CoreSkills, BaseInfo>(Paths.CoreSkillsInfoUrl);
		_attributes = await Load<Attributes, BaseInfo>(Paths.AttributesInfoUrl);

		_discs = await Load<Discs, DiscInfo>(Paths.DiscsInfoUrl);
		_engines = await Load<Engines, EngineInfo>(Paths.EnginesInfoUrl);
		_stats = await Load<Stats, StatInfo>(Paths.StatsInfoUrl);
	}

	async Task<Dictionary<T, TInfo>> Load<T, TInfo>(string url) where TInfo : BaseInfo where T : struct, Enum {
		var info = await http.GetFromJsonAsync<ModelInfo<TInfo>>(url);
		Debug.Assert(info != null, nameof(info) + " != null");

		// map the info to the enum
		var ret = info.Info.ToDictionary(x => Enum.Parse<T>(x.Id), x => {
			x.DisplayName = lang[Enum.Parse<T>(x.Id)];
			x.Url = info.UrlTemplate
				.Replace("{Icon}", x.Icon)
				.Replace("{Id}", x.Id)
				.Replace("{Id_}", x.Id.ToUnderscore());
			x.PostLoad(lang, info);
			return x;
		});

		return ret;
	}
}