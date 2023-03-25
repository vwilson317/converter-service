[AttributeUsage(AttributeTargets.Property)]
public class PathAttribute : Attribute
{
    public string Value { get; private set; }
    public char? Separator { get; set; }

    public PathAttribute(string value)
    {
        var separator = value.Split(':');
        if (separator.Length > 1)
        {
            Value = separator[0];
            Separator = char.Parse(separator[1]);
        }
        else
        {
            Value = value;
            separator = null;
        }
    }
}