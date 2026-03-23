public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] reverseA = new char[input.Length];
        int counter = 0;
        for (int i = input.Length; i > 0; i--)
        {
            reverseA[counter++] = input[i - 1];
        }

        return new string(reverseA);
    }
}