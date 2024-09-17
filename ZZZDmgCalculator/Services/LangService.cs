namespace ZZZDmgCalculator.Services;

using System.Resources;

/// <summary>
/// Provides access to the language resources.
/// </summary>
public class LangService {
	readonly ResourceManager _manager;

	public LangService() {
		_manager = new ResourceManager("ZZZDmgCalculator.Lang.Resources", typeof(LangService).Assembly);
	}

	public string this[string key] => _manager.GetString(key) ?? $"%{key}%";

	public string this[Enum key] => this[$"{key.GetType().Name}.{key}"];
}