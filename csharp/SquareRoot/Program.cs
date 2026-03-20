public static class SquareRoot
{
    public static int Root(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            int temp = i * i;
            if(temp == number)
            {
                return i;
            }
        }

        return -1;
    }
}
