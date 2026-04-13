public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        List<int> ohm = new List<int>();
        if (colors.Length >= 3)
        {

            for (int i = 0; i < 2; i++)
            {
                if (colormatch.ContainsKey(colors[i])) ohm.Add(colormatch[colors[i]]);
                else throw new InvalidOperationException("Color not found.");
            }
        }
        else throw new InvalidOperationException("Array must have at least 3 entries");

        int basevalue = ohm[0] * 10 + ohm[1];
        int multiplier;
        if (colormatch.ContainsKey(colors[2])) multiplier = colormatch[colors[2]];
        else throw new InvalidOperationException("Color not found.");
        long value = basevalue;
        for (int i = 0; i < multiplier; i++)
        {
            value *= 10;
        }

        return value switch
        {
            >= 1000000000 => $"{value / 1000000000} gigaohms",
            >= 1000000 => $"{value / 1000000} megaohms",
            >= 1000 => $"{value / 1000} kiloohms",
            _ => $"{value} ohms"
        };

    }

    public static Dictionary<string, int> colormatch = new()
    {
        {"black", 0},
        {"brown", 1},
        {"red", 2},
        {"orange", 3},
        {"yellow", 4},
        {"green", 5},
        {"blue", 6},
        {"violet", 7},
        {"grey", 8},
        {"white", 9},
    };
}
