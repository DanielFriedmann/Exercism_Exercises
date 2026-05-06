public static class FoodChain
{

    private static readonly (string Name, string Comment)[] Animals =
    {
    ("fly",    ""),
    ("spider", "It wriggled and jiggled and tickled inside her."),
    ("bird",   "How absurd to swallow a bird!"),
    ("cat",    "Imagine that, to swallow a cat!"),
    ("dog",    "What a hog, to swallow a dog!"),
    ("goat",   "Just opened her throat and swallowed a goat!"),
    ("cow",    "I don't know how she swallowed a cow!"),
    ("horse",  "She's dead, of course!"),
    };

    public static string Recite(int verseNumber)
    {
        List<string> lines = new List<string>();
        var (name, comment) = Animals[verseNumber - 1];

        lines.Add($"I know an old lady who swallowed a {name}.");

        if (!string.IsNullOrEmpty(comment)) lines.Add(comment);

        if (name == "horse") return string.Join("\n", lines);

        for (int i = verseNumber - 1; i >= 1; i--)
        {
            string current = Animals[i].Name;
            string prev = Animals[i - 1].Name;

            string prevText = prev == "spider" ? "spider that wriggled and jiggled and tickled inside her" : prev;

            lines.Add($"She swallowed the {current} to catch the {prevText}.");

        }

        lines.Add("I don't know why she swallowed the fly. Perhaps she'll die.");

        return string.Join("\n", lines);



    }

    public static string Recite(int startVerse, int endVerse)
    {
        return string.Join("\n\n",
            Enumerable.Range(startVerse, endVerse - startVerse + 1)
                      .Select(v => Recite(v)));
    }
}