using System.Text.RegularExpressions;

public class LogParser
{
    public string[] validLogs = { "[TRC]", "[DBG]", "[INF]", "[WRN]", "[ERR]", "[FTL]" };
    public bool IsValidLine(string text) => validLogs.Any(log => text.StartsWith(log));

    public string[] SplitLogLine(string text) => Regex.Split(text, @"<[\^\*\=\-]*>");

    public int CountQuotedPasswords(string lines) => Regex.Matches(lines, @"""[^""]*password[^""]*""",
                                                    RegexOptions.IgnoreCase | RegexOptions.Multiline).Count;

    public string RemoveEndOfLineText(string line) => Regex.Replace(line, @"end-of-line\d+", "");

    public string[] ListLinesWithPasswords(string[] lines)
    {
        List<string> result = new List<string>();

        foreach (var line in lines)
        {
            var match = Regex.Match(line, @"\bpassword\S+", RegexOptions.IgnoreCase);

            if (match.Success)
                result.Add($"{match.Value}: {line}");
            else
                result.Add($"--------: {line}");
        }

        return result.ToArray();
    }
}
