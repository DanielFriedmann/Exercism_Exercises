using System.Security.Cryptography;

public static class Rectangles
{
    public static int Count(string[] rows)
    {
        int rectangles = 0;

        for (int row1 = 0; row1 < rows.Length; row1++)
            for (int row2 = row1 + 1; row2 < rows.Length; row2++)
                for (int col1 = 0; col1 < rows[row1].Length; col1++)
                    for (int col2 = col1 + 1; col2 < rows[row1].Length; col2++)
                    {
                        if(IsRectangle(rows, row1, col1, row2, col2)) rectangles++;
                    }

        return rectangles;
    }

    public static bool IsRectangle(string[] rows, int row1, int col1, int row2, int col2)
    {
        if (rows[row1][col1] != '+') return false;
        if (rows[row1][col2] != '+') return false;
        if (rows[row2][col1] != '+') return false;
        if (rows[row2][col2] != '+') return false;

        for (int i = col2 - col1; i > 0; i--)
        {
            if (rows[row1][col1 + i] != '+' && rows[row1][col1 + i] != '-') return false;
        }

        for (int i = col2 - col1; i > 0; i--)
        {
            if (rows[row2][col1 + i] != '+' && rows[row2][col1 + i] != '-') return false;
        }

        for (int i = row2 - row1; i > 0; i--)
        {
            if (rows[row1 + i][col1] != '+' && rows[row1 + i][col1] != '|') return false;
        }

        for (int i = row2 - row1; i > 0; i--)
        {
            if (rows[row1 + i][col2] != '+' && rows[row1 + i][col2] != '|') return false;
        }

        return true;

    }
}