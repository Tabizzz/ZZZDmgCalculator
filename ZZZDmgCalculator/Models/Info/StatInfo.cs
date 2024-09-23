namespace ZZZDmgCalculator.Models.Info;

public class StatInfo : BaseInfo {
	
	public bool IsMain { get; set; }

	public bool IsSub { get; set; }
	
	public DiscStatInfo[] DiscData { get; set; } = [];
}