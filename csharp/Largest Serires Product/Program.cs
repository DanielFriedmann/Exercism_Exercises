public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        long biggestProduct = 0;

        if (span > digits.Length || span < 0) throw new ArgumentException("Span is longer than the given input string.");
        if (span == 0) return 1;

        for (int i = 0; i + span <= digits.Length; i++)
        {
            string temp = digits.Substring(i, span);

            if (temp.All(char.IsDigit))
            {
                long product = 1;

                foreach (char c in temp)
                {
                    product *= c - '0';
                }

                if (product > biggestProduct) biggestProduct = product;

            }
            else throw new ArgumentException("Wrong Input.");
        }

        return biggestProduct;
    }
}