public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int temp = 0;
        for(int i = 0; i <= max; i++)
        {
            temp += i;
        }

        return temp * temp;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int temp = 0;
        for(int i = 1; i <= max; i++)
        {
            temp += i * i;
        }

        return temp;
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
  
}