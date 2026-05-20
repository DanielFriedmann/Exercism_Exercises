public static class ParallelLetterFrequency
{
    public static Task<Dictionary<char, int>> Calculate(IEnumerable<string> texts)
    {
        return Task.Run(() => texts.AsParallel()
                    .SelectMany(text => text)
                    .Where(c => char.IsLetter(c))
                    .Select(c => char.ToLower(c))
                    .GroupBy(c => c)
                    .ToDictionary(group => group.Key, group => group.Count()));
    }
}