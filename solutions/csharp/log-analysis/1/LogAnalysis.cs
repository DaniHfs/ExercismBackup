public static class LogAnalysis 
{
    // Get string after delimiter
    public static string SubstringAfter(this string str, string delim)
        => str[(str.IndexOf(delim) + delim.Length)..];

    // Get string between delimiters
    public static string SubstringBetween(this string str, string delim1, string delim2)
    {
        int start = str.IndexOf(delim1) + delim1.Length;
        int end = str.IndexOf(delim2);

        return str[start..end].Trim();
    }
    // Get message
    public static string Message(this string str)
        => str[(str.IndexOf("]: ") + 3)..].Trim();
    
    // Get log level
    public static string LogLevel(this string str)
        => str[1..str.IndexOf(']')].Trim();
}