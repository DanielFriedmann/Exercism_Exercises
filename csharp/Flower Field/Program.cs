public static class FlowerField
{
    public static string[] Annotate(string[] input)
    {
        string[] result = new string[input.Length];

        for (int row = 0; row < input.Length; row++)
        {
            char[] rowChars = input[row].ToCharArray();

            for (int col = 0; col < input[row].Length; col++)
            {
                if (input[row][col] == '*') continue;
                int counter = 0;

                for (int dr = -1; dr <= 1; dr++)
                {
                    for (int dc = -1; dc <= 1; dc++)
                    {
                        int newRow = row + dr;
                        int newCol = col + dc;
                        if (newRow >= 0 && newRow < input.Length &&
                            newCol >= 0 && newCol < input[row].Length)
                            if (input[newRow][newCol] == '*') counter++;
                    }
                }

                if (counter > 0) rowChars[col] = (char)('0' + counter);
            }
            result[row] = new string(rowChars);
        }

        return result;
    }
}
