namespace ZZZDmgCalculator.Data;

using Models.Enum;
using Models.Info;

[UrlTemplate("icons/attributes/Icon_{Id}.webp")]
[InfoData<Attributes>]
public static class AttributesData {
	public readonly static Dictionary<Attributes, BaseInfo> Data = new()
	{
		[Attributes.Fire] = new()
		{
			Id = nameof(Attributes.Fire),
		},
		[Attributes.Ice] = new()
		{
			Id = nameof(Attributes.Ice),
		},
		[Attributes.Physical] = new()
		{
			Id = nameof(Attributes.Physical),
		},
		[Attributes.Electric] = new()
		{
			Id = nameof(Attributes.Electric),
		},
		[Attributes.Ether] = new()
		{
			Id = nameof(Attributes.Ether),
		},
	};
}