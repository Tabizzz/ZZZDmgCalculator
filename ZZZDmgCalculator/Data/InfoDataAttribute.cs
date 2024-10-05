namespace ZZZDmgCalculator.Data;

[AttributeUsage(AttributeTargets.Class)]
public class InfoDataAttribute<T> : InfoDataAttribute
	where T : struct, Enum {
	public InfoDataAttribute(T field) {
		Field = field;
	}

	public InfoDataAttribute() {
		Field = null;
	}

	public T? Field { get; }
}
[AttributeUsage(AttributeTargets.Class)]
public class InfoDataAttribute : Attribute {}