namespace Assignment2;
using System.Collections;

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

    public static int[] DivisibleNumbers(this int[] array)
    {

        var divisibleList = new int[array.Length];
        int counter = 0;

        foreach (var item in array)
        {
            if ((item % 7 == 0) && (item > 42))
            {
                divisibleList[counter] = item;
            }
            counter++;
        }
        return divisibleList;
    }

    public static int[] IsLeapYear(this int[] array)
    {

        var leapYearList = new int[array.Length];
        int counter = 0;

        foreach (var year in array)
        {
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                leapYearList[counter] = year;
            }
            counter++;
        }
        return leapYearList;
    }
}