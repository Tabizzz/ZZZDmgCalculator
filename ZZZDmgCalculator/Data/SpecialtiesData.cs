namespace ZZZDmgCalculator.Data;

using Models.Enum;
using Models.Info;

[UrlTemplate("icons/specialties/Icon_{Id}.webp")]
[InfoData<Specialties>]
public static class SpecialtiesData {
	public readonly static Dictionary<Specialties, BaseInfo> Data = new()
	{
		[Specialties.Attack] = new()
		{
			Id = nameof(Specialties.Attack),
		},
		[Specialties.Defense] = new()
		{
			Id = nameof(Specialties.Defense),
		},
		[Specialties.Support] = new()
		{
			Id = nameof(Specialties.Support),
		},
		[Specialties.Anomaly] = new()
		{
			Id = nameof(Specialties.Anomaly),
		},
		[Specialties.Stun] = new()
		{
			Id = nameof(Specialties.Stun),
		},
	};
}