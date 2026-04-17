public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> newdict = new Dictionary<string,int>();

        foreach (var kvp in old)
        {
            foreach (string s in kvp.Value)
            {
                newdict.Add(s.ToLower(), kvp.Key);
            }
        }
        return newdict;
    }
}