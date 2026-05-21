public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        return phrase.Split(new char[] {' ', ',', '.', '!', '?', ':', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                     .Select(word => new string(word.Where(c => char.IsLetterOrDigit(c) || c == '\'').ToArray()))
                     .Select(word => word.Trim('\'').ToLower())
                     .Where(word => word.Length > 0)                     
                     .GroupBy(word => word)
                     .ToDictionary(word => word.Key, word => word.Count());
    }
}