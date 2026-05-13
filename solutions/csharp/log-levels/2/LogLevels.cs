static class LogLine
{
    // Extract message by skipping the level label
    public static string Message(string logLine)
        => logLine.Substring(logLine.IndexOf("]: ") + 3).Trim();

    // Extract level
    public static string LogLevel(string logLine)
        => logLine.Substring(1, logLine.IndexOf(']') - 1).Trim().ToLower();

    public static string Reformat(string logLine)
        => $"{Message(logLine)} ({LogLevel(logLine)})";
}
