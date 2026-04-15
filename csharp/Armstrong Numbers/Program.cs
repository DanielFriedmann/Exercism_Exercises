public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        if( number >= 0)
        {
            int pow = number.ToString().Length;
            int sum = 0;

            foreach(char c in number.ToString())
            {
                int digit = c - '0';
                sum += (int)Math.Pow(digit, pow);
            }

            return sum == number;
        }
        else throw new ArgumentOutOfRangeException("");
    }
}