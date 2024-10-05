namespace ZZZDmgCalculator.Models.Enum;

/// <summary>
/// List of ways to activate a buff.
/// </summary>

public enum BuffTrigger {
	/// <summary>
	/// In switch mode the buff can de enabled or disabled.
	/// </summary>
	Switch,
	/// <summary>
	/// In stack mode the buff can be stacked. This means the buff with 0 stacks is disabled
	/// and the buff value varies depending on the number of stacks.
	/// </summary>
	Stack,
	/// <summary>
	/// The buff is permanent and cannot be disabled.
	/// </summary>
	Permanent
}