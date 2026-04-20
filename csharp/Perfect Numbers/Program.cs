public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException();
        
        List<int> divisors = new List<int>();
        int aliquot = 0;

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                divisors.Add(i);
                aliquot += i;
            }
        }

        if(number == aliquot) return Classification.Perfect;

        if(number < aliquot) return Classification.Abundant;

        return Classification.Deficient;

    }
}
