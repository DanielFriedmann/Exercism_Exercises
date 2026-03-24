public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        string binary = Convert.ToString(encodedCount, 2);
        int eggs = 0;
        foreach(char c in binary)
        {
            if (c == '1') eggs++;
        }
        return eggs;
    }
}
