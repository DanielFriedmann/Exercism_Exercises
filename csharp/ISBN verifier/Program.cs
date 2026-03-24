public static class IsbnVerifier
{
    public static bool IsValid(string number)
    {
        string neu = number.Replace("-", "");
        if (neu.Length == 10)
        {
            if (neu[neu.Length - 1] == 'X')
            {
                int count = 10;
                int sum = 10;
                for (int i = 0; i < 9; i++)
                {
                    sum += (neu[i] - '0')* count--;
                }

                if (sum % 11 == 0) return true;
                else return false;
            }
            else
            {
                int count = 10;
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += (neu[i] - '0') * count--;
                }

                if (sum % 11 == 0) return true;
                else return false;
            }
        }
        else return false;
    }
}