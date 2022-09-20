namespace Assignment2;

public static class Extensions
{
    public static bool IsSafe(this Uri uri)
    {
        if (uri.Scheme == Uri.UriSchemeHttps)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int WordCount(this string str)
    {
        char[] delimters = new char[] { ' ', '\n', '\r' };
        return str.Split(delimters, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static IEnumerable<T> FlattenNumbers<T>(this IEnumerable<IEnumerable<T>> items)
    {
        foreach (var list in items)
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }
    }

    public static IEnumerable<int> DivisibleNumbers(this IEnumerable<int> items)
    {
        foreach (var item in items)
        {
            if ((item % 7 == 0) && (item > 42))
            {
                yield return item;
            }
        }
    }

    public static IEnumerable<int> IsLeapYear(this IEnumerable<int> items)
    {
        foreach (var year in items)
        {
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                yield return year;
            }
        }
    }
}