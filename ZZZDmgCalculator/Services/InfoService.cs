namespace ZZZDmgCalculator.Services;

using System.Diagnostics;
using System.Net.Http.Json;
using Config;
using Models.Enum;
using Models.Info;

/// <summary>
/// Load and manages info about the models.
/// </summary>
public class InfoService (HttpClient http, LangService lang) {

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
	
	public async Task LoadAll() {
		_factions = await Load<Factions, BaseInfo>(Paths.FactionsInfoUrl);
		_specialties = await Load<Specialties, BaseInfo>(Paths.SpecialtiesInfoUrl);
		_skills = await Load<Skills, BaseInfo>(Paths.SkillsInfoUrl);
		_coreSkills = await Load<CoreSkills, BaseInfo>(Paths.CoreSkillsInfoUrl);
		_attributes = await Load<Attributes, BaseInfo>(Paths.AttributesInfoUrl);
	}
	
	async Task<Dictionary<T,TInfo>> Load<T, TInfo>(string url) where TInfo : BaseInfo where T : struct {
		var info = await http.GetFromJsonAsync<ModelInfo<TInfo>>(url);
		Debug.Assert(info != null, nameof(info) + " != null");
		
		// map the info to the enum
		var ret = info.Info.ToDictionary(x => Enum.Parse<T>(x.Id), x => {
			
			x.DisplayName = lang[(Enum.Parse<T>(x.Id) as Enum)!];
			x.Url = info.UrlTemplate
				.Replace("{Icon}", x.Icon)
				.Replace("{Id}", x.Id);
#if DEBUG
		Console.WriteLine(@"Loaded item {0}, Name: {1}, IconUrl: {2}", x.Id, x.DisplayName, x.Url);	
#endif
			return x;
		});
		
		return ret;
	}
}