public static class Extensions
{
    public static IEnumerable<Type> FindSubClasses(this Type baseType)
    {
        var assembly = baseType.Assembly;

        return assembly.GetTypes().Where(t => t.IsSubclassOf(baseType));
    }
}