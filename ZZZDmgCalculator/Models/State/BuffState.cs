namespace ZZZDmgCalculator.Models.State;

using Enum;
using Info;

public class BuffState(BuffInfo info) {
	int _stacks;

	public bool Enabled { get; set; }

	public int Stacks
	{
		get => _stacks;
		set => _stacks = Math.Clamp(value, 0, info.Stacks);
	}

	public int MaxStacks => info.Stacks;
	
	public int ValueMultiplier => info.Type switch { BuffTrigger.Stack => _stacks, _ => 1 };

	public bool Active => info.Type switch { BuffTrigger.Stack => Stacks > 0, BuffTrigger.Switch => Enabled, _ => true };

	public bool IsScaling => info.Scales is not null;

	public bool HasDependencies => info.Depends is not null;

	public required List<StatModifier> Buffs { get; init; }

	public BuffInfo Info => info;
	
}