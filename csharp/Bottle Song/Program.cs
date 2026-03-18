public static class BottleSong
{
    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {
        List<string> verses = new List<string>();

        for (int i = 0; i < takeDown; i++)
        {
            int current = startBottles - i;
            int next = current - 1;

            string verse1 = Capitalize(GetString(current)) + " hanging on the wall,";
            string verse2 = Capitalize(GetString(current)) + " hanging on the wall,";
            string verse3 = "And if one green bottle should accidentally fall,";
            string verse4 = "There'll be " + GetString(next) + " hanging on the wall.";

            verses.Add(verse1);
            verses.Add(verse2);
            verses.Add(verse3);
            verses.Add(verse4);

            if (i < takeDown - 1)
            {
                verses.Add("");
            }
        }

        return verses;
    }

    public static string Capitalize(string text)
    {
        return char.ToUpper(text[0]) + text.Substring(1);
    }

    public static string GetString(int number)
    {
        string temp = "";
        switch (number)
        {
            case 10: temp = "ten green bottles"; break;
            case 9: temp = "nine green bottles"; break;
            case 8: temp = "eight green bottles"; break;
            case 7: temp = "seven green bottles"; break;
            case 6: temp = "six green bottles"; break;
            case 5: temp = "five green bottles"; break;
            case 4: temp = "four green bottles"; break;
            case 3: temp = "three green bottles"; break;
            case 2: temp = "two green bottles"; break;
            case 1: temp = "one green bottle"; break;
            case 0: temp = "no green bottles"; break;
        }
        return temp;
    }
}