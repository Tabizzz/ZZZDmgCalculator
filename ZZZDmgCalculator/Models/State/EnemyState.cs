namespace ZZZDmgCalculator.Models.State;

using Enum;

public class EnemyState {
	public EntityState Stats { get; set; } = new ();
	
	public int Level { get; set; }
	
	public int StunMultiplier { get; set; }
	
	public List<Attributes> Resistances { get; set; } = [];
	
	public List<Attributes> Weaknesses { get; set; } = [];
	
	public int BaseDefense { get; set; }
}