public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        int countA = 0; int countC = 0; int countG = 0; int countT = 0;

        foreach (char c in sequence)
        {
            switch (c)
            {
                case 'A': countA++; break;
                case 'C': countC++; break;
                case 'G': countG++; break;
                case 'T': countT++; break;
                default: throw new ArgumentException("Invalid Operation - Wrong String.");
            }
        }

        return new Dictionary<char, int>
        {
            { 'A', countA },
            { 'C', countC },
            { 'G', countG },
            { 'T', countT },
        };        

    }
}