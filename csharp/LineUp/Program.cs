public static class LineUp
{
    public static string Format(string name, int number)
    {
        string numbers = number.ToString();
        char last = numbers[numbers.Length - 1];
        string twonumbers = "";
        if (numbers.Length > 1)
        {
            twonumbers = numbers.Substring(numbers.Length - 2, 2);
        }


        string suffix;

        if (last == '1' && twonumbers != "11") suffix = "st";
        else if (last == '2' && twonumbers != "12") suffix = "nd";
        else if (last == '3' && twonumbers != "13") suffix = "rd";
        else suffix = "th";

        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
    }
}
