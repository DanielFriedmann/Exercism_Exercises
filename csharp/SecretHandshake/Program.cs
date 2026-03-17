public static class SecretHandshake
{
    public static void Main(string[] args)
    {
        string[] tester = Commands(26);
        foreach(string t in tester)
        {
            Console.WriteLine(t);
        }
    }
    public static string[] Commands(int commandValue)
    {
        string binary = Convert.ToString(commandValue, 2);
        binary = binary.PadLeft(5, '0');
        char[] chars = binary.ToCharArray();
        List<string> result = new List<string>();

        if(chars[4] == '1') result.Add("wink");
        if(chars[3] == '1') result.Add("double blink");
        if(chars[2] == '1') result.Add("close your eyes");
        if(chars[1] == '1') result.Add("jump");
        if(chars[0] == '1') result.Reverse();

        return result.ToArray();
    }
}
