public class DndCharacter
{
    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public int Hitpoints { get; }


    public DndCharacter(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int hitpoints)
    {
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
        Hitpoints = hitpoints;
    }

    public static Random random = new Random();

    public static int Modifier(int score) => (int)Math.Floor((score - 10) / 2.0);

    public static int Ability()
    {
        int[] rolls =
     {
        random.Next(1, 7),
        random.Next(1, 7),
        random.Next(1, 7),
        random.Next(1, 7)
    };

        Array.Sort(rolls);

        return rolls[1] + rolls[2] + rolls[3];
    }

    public static DndCharacter Generate()
    {
        int constitution = Ability();
        int hitpoints = 10 + Modifier(constitution);

        return new DndCharacter(Ability(), Ability(), constitution, Ability(), Ability(), Ability(), hitpoints);
    }
}
