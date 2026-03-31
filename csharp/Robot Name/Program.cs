public class Robot
{
    private static HashSet<string> usedNames = new HashSet<string>();
    private static Random random = new Random();

    private string name;

    public string Name
    {
        get
        {
            if (name == null)
            {
                name = GenerateUniqueName();
            }
            return name;
        }
    }

    public void Reset()
    {
        if (name != null)
        {
            usedNames.Remove(name);
        }

        name = null;
    }

    private string GenerateUniqueName()
    {
        string newName;

        do
        {
            newName = GenerateRandomName();
        }
        while (usedNames.Contains(newName));

        usedNames.Add(newName);
        return newName;
    }

    private string GenerateRandomName()
    {
        char[] chars = new char[5];

        for (int i = 0; i < 5; i++)
        {
            if (i < 2)
                chars[i] = (char)('A' + random.Next(0, 26));
            else
                chars[i] = (char)('0' + random.Next(0, 10));
        }

        return new string(chars);
    }
}