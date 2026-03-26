public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long> longs = new List<long>();
        long temp = number;
        do
        {
            for (int i = 2; i <= temp; i++)
            {
                if (temp % i == 0)
                {
                    temp = temp / i;
                    longs.Add(i);
                    break;
                }              
            }

        } while (temp > 1);

        return longs.ToArray();
    }
}