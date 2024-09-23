namespace ZZZDmgCalculator.Models.Info;

using System.Text.Json.Serialization;
using Enum;

public class BuffInfo : BaseInfo {
	public string Description { get; set; } = string.Empty;
	
	public BuffTrigger Type { get; set; }
	/// <summary>
	/// Only used when <see cref="Type"/> is <see cref="BuffTrigger.Stack"/>.
	/// </summary>
	public int Stacks { get; set; }
	
	/// <summary>
	/// Used to specify this buff can scale, for example with level or engine refinement.
	/// </summary>
	public string? Scale { get; set; }
    
	/// <summary>
	/// A condition that must be met for this buff to be applied or enabled.
	/// </summary>
    public string? Condition { get; set; }
	
	public bool Pass { get; set; }
	
	/// <summary>
	/// This buff depends on another buff, this is used to create a chain of buffs.
	/// If the other buff is not active, this buff is not going to be applied and cannot by enabled on the UI.
	/// </summary>
	public int? Depends { get; set; }
	
	/// <summary>
	/// If <see cref="Depends"/> is set and the dependent buff is stackable, this is the amount of stacks required to enable this buff.
	/// </summary>
	public int? RequiredStacks { get; set; }
	
	[JsonInclude]
	internal List<StatModifier> Buffs { get; set; } = [];
	public StatModifier? Buff { get; set; }

	[JsonIgnore]
	public List<StatModifier> BuffList
	{
		get
		{
			if (Buff is null) return Buffs;
			Buffs.Insert(0, Buff);
			Buff = null;
			return Buffs;
		}
	}
}