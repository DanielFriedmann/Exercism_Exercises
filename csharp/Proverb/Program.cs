public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        string[] recites = new string[subjects.Length];
        if (subjects.Length > 0)
        {
            for (int i = 0; i < subjects.Length - 1; i++)
            {
                recites[i] = $"For want of a {subjects[i].Trim()} the {subjects[i + 1].Trim()} was lost.";
            }

            recites[recites.Length - 1] = $"And all for the want of a {subjects[0].Trim()}.";
        }

        return recites;
    }
}