public static class Luhn
{
    public static bool IsValid(string number)
    {
        string temp = number.Replace(" ", "");
        if(temp.Length > 1)
        {
            
            char[] array = temp.ToCharArray();
            int sum = 0;
            foreach(char c in temp)
            {
                if(!char.IsDigit(c)) return false;
            }
            for(int i = array.Length - 2; i >= 0; i = i - 2)
            {
                int zahl = (array[i] - '0') * 2;                
                if (zahl > 9) zahl -= 9;
                array[i] = (char)(zahl + '0');
            }
            foreach(char c in array)
            {
                sum += c - '0';
            }
            return sum % 10 == 0;
        }
        else return false;
    }
}