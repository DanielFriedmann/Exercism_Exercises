public static class House
{

    private static readonly (string Subject, string Action)[] Parts =
    {
        ("the house", "Jack built."),
        ("the malt", "lay in"),
        ("the rat", "ate"),
        ("the cat", "killed"),
        ("the dog", "worried"),
        ("the cow with the crumpled horn", "tossed"),
        ("the maiden all forlorn", "milked"),
        ("the man all tattered and torn", "kissed"),
        ("the priest all shaven and shorn", "married"),
        ("the rooster that crowed in the morn", "woke"),
        ("the farmer sowing his corn", "kept"),
        ("the horse and the hound and the horn", "belonged to"),
    };

    public static string Recite(int verseNumber)
    {

        string result = $"This is {Parts[verseNumber - 1].Subject}";

        for (int i = verseNumber - 1; i >= 0; i--)
        {
            result += $" that {Parts[i].Action}";
            if (i > 0) result += $" {Parts[i - 1].Subject}";
        }

        return result;
    }

    public static string Recite(int startVerse, int endVerse)
    {
        return string.Join("\n", Enumerable.Range(startVerse, endVerse - startVerse + 1)
                                             .Select(v => Recite(v)));
    }
}