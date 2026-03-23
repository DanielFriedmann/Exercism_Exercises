using System.Globalization;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        int c;
        var result = new List<(int, int ,int)>();

        for(int i = 1; i <= sum / 3; i++)
        {
            for(int j = i + 1; j <= (sum - i) / 2; j++)
            {
                c = sum - i - j;

                if(i * i + j * j == c * c)
                {
                    result.Add((i, j, c));
                }
            }
        }

        return result;
    }
}