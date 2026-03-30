public static class Languages
{
    public static List<string> languages = new List<string>();
    public static List<string> NewList()
    {
        return new List<string> { };
    }

    public static List<string> GetExistingLanguages()
    {
        languages.Add("C#");
        languages.Add("Clojure");
        languages.Add("Elm");
        return languages;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count();
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;

    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count > 0)
        {
            if (languages[0] == "C#" || languages[1] == "C#" && (languages.Count() == 2 || languages.Count() == 3))
            {
                return true;
            }
            else return false;
        }
        else return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        languages.Sort();
        bool unique = true;
        for (int i = 0; i < languages.Count - 1; i++)
        {
            if (languages[i] == languages[i + 1]) return false;
        }
        return unique;
    }
}
