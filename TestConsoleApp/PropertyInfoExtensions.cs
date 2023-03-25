using System.Reflection;

public static class PropertyInfoExtensions
{
    public static T GetAttribute<T>(this PropertyInfo propertyInfo) where T : Attribute
    {
        return (T)propertyInfo.GetCustomAttributes(typeof(T), false).FirstOrDefault();
    }
}