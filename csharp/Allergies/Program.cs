public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly int mask;
    public Allergies(int mask)
    {
        this.mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (mask & (int)allergen) != 0;
    }

    public Allergen[] List()
    {
        List<Allergen> result = new List<Allergen>();

        foreach(Allergen allergen in Enum.GetValues<Allergen>())
        {
            if(IsAllergicTo(allergen)) result.Add(allergen);
        }

        return result.ToArray();
    }
}