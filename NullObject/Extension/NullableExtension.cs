namespace NullObject.Extension;

//Second Method of Null Object
public static class NullableExtension
{
    public static bool IsNull<T>(this T entity)
    {
        return entity == null;
    }

    public static bool IsNotNull<T>(this T entity)
    {
        return entity != null;
    }
}