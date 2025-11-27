namespace WinFormsApp1;

public static class Utils
{
    public static string ToCommaSepString<T>(this IEnumerable<T> source, string delim = ", ")
    {
        return string.Join(delim, source);
    }
}
