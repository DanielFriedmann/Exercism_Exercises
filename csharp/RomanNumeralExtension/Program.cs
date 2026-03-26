using System.Text;
public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        
        var numberconversion = new (int Value, string Symbol)[]
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        var sb = new StringBuilder();
        
        foreach (var number in numberconversion)
        {
            while( value >= number.Value)
            {
                sb.Append(number.Symbol);
                value -= number.Value;
            }
        }

        return sb.ToString();       
    
    }
}