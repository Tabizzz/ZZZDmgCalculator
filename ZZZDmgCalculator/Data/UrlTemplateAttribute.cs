namespace ZZZDmgCalculator.Data;

[AttributeUsage(AttributeTargets.Class)]
public class UrlTemplateAttribute(string template) : Attribute {
	public string Template { get; } = template;

}