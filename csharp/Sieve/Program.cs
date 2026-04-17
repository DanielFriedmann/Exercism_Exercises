public static class Sieve
{
    public static int[] Primes(int limit)
    {
        /* List<int> init = new List<int>();

        for(int i = 2; i <= limit; i++)
        {
            init.Add(i);
        }

        for(int i = 0; i < init.Count; i++)
        {
            for(int j = 2; j <= limit; j++)
            {
                if(init.Contains(init[i]*j)) init.Remove(init[i]*j);
            }
        }
        return init.ToArray(); */

        if (limit < 2)
            return Array.Empty<int>();

        bool[] isPrime = new bool[limit + 1];

        for (int i = 2; i <= limit; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= limit; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= limit; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        List<int> primes = new List<int>();

        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i])
                primes.Add(i);
        }

        return primes.ToArray();

    }
}