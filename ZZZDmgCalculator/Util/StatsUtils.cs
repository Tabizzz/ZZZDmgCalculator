namespace ZZZDmgCalculator.Util;

using System.Globalization;
using Models.Enum;
using static Models.Enum.Stats;

public static class StatsUtils {

	public static string Format(this Stats stat, double value) {
		var percent = stat is >= CritRate and <= PenRatio or >= ElectricDmg ? " %" : string.Empty;
		if (stat == EnergyRegen)
		{
			return $"{value:0.0#}";
		}
		return percent == string.Empty ? $"{value:N0}" : $"{value:N1}%";
	}
}