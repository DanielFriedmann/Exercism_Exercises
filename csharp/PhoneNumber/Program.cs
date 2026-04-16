public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        List<char> numbers = new List<char>();

        foreach (char c in phoneNumber)
        {
            if (char.IsDigit(c)) numbers.Add(c);
        }


        if (numbers.Count == 11 && numbers[0] == '1') numbers.RemoveAt(0);        

        if (numbers.Count == 10)
        {
            if (numbers[0] == '0' || numbers[0] == '1') throw new ArgumentException("");
            else if (numbers[3] == '0' || numbers[3] == '1') throw new ArgumentException("");
            else return string.Join("", numbers);
        }
        else throw new ArgumentException("No correct Phone Number retrievable");
    }
}