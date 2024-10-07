namespace ZZZDmgCalculator.Services;

using System.Resources;

/// <summary>
/// Provides access to the language resources.
/// </summary>
public class LangService {
	readonly ResourceManager _manager;

	public LangService() {
		_manager = new("ZZZDmgCalculator.Lang.Resources", typeof(LangService).Assembly);
	}
#if DEBUG
	readonly List<string> _warnKeys = [];
	
	public string this[string key]
	{
		get
		{
			var value = _manager.GetString(key);
			if (value is null && !_warnKeys.Contains(key))
			{
				Console.WriteLine($@"Missing Lang Key: {key}");
				_warnKeys.Add(key);
			}
			return value ?? $"%{key}%";
		}
	}

	public string this[Enum key] => this[$"{key.GetType().Name}.{key}"];
#else
	public string this[string key] => _manager.GetString(key) ?? $"%{key}%";

	public string this[Enum key] => this[$"{key.GetType().Name}.{key}"];
#endif
}