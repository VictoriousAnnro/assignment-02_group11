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
}