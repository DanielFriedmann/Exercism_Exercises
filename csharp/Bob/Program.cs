public static class Bob
{
    public static string Response(string statement)
    {
        bool isYelling =
            statement.Any(char.IsLetter) &&
            statement.All(c => !char.IsLetter(c) || char.IsUpper(c));
        string trimmed = statement.Trim();

        if (string.IsNullOrWhiteSpace(trimmed)) return "Fine. Be that way!";
        else if (trimmed[^1] == '?' && isYelling) return "Calm down, I know what I'm doing!";
        else if (trimmed[^1] == '?') return "Sure.";
        else if (isYelling) return "Whoa, chill out!";
        else return "Whatever.";
    }
}