public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
           Array.Sort(input);

        int left = 0;
        int right = input.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;

            if (input[middle] == value)
            {
                return middle;
            }
            else if (value < input[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return -1;
    }
    
}