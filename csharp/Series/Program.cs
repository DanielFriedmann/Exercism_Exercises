public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        List<string> slices = new List<string>();

        if (sliceLength <= 0) throw new ArgumentException("Slice Length cant be 0 or negative");

        if (numbers.Length >= sliceLength)
        {
            while (numbers.Length >= sliceLength)
            {
                string temp = numbers.Substring(0, sliceLength);
                slices.Add(temp);
                numbers = numbers.Remove(0, 1);
            }
            return slices.ToArray();
        }
        else throw new ArgumentException("Slice Length too big for this string.");        
    }
}