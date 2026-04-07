public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {

        try
        {
            if (operation == "+")
                return $"{operand1} + {operand2} = {operand1 + operand2}";

            else if (operation == "*")
                return $"{operand1} * {operand2} = {operand1 * operand2}";

            else if (operation == "/" && operand2 != 0)
                return $"{operand1} / {operand2} = {operand1 / operand2}";

            else if (operation == "/")
                throw new DivideByZeroException();

            else if (operation == "")
                throw new ArgumentException("Empty String.");

            else if (operation == null)
                throw new ArgumentNullException("Operation cant be null.");

            else
                throw new ArgumentOutOfRangeException("False Operation.");
        }    

        catch (DivideByZeroException)
        {
            return $"Division by zero is not allowed.";
        }      
               

    }
}
