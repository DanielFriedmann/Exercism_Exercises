public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string temp = phrase.Replace("-", " ");
        string[] phrases = temp.Split(" ");
        string abbreviate = "";

        foreach (string p in phrases)
        {
            if (string.IsNullOrWhiteSpace(p)) continue;

            foreach (char c in p)
            {
                if (char.IsLetter(c))
                {
                    abbreviate += c;
                    break;
                }
            }
        }
        return abbreviate.ToUpper();
    }
}