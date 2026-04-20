public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{
    public string[] rows;

    public string[] students =
 {
    "Alice", "Bob", "Charlie", "David",
    "Eve", "Fred", "Ginny", "Harriet",
    "Ileana", "Joseph", "Kincaid", "Larry"
};
    public KindergartenGarden(string diagram)
    {
        rows = diagram.Split('\n');
    }

    public IEnumerable<Plant> Plants(string student)
    {       
        List<Plant> plants = new List<Plant>();

        int counter = Array.IndexOf(students, student);
        if (counter == -1) throw new ArgumentException("Student not found.");
        int start = counter * 2;

        plants.Add(ToPlant(rows[0][start]));
        plants.Add(ToPlant(rows[0][start + 1]));  
        plants.Add(ToPlant(rows[1][start]));  
        plants.Add(ToPlant(rows[1][start + 1]));              

        return plants;
    }

    public Plant ToPlant(char c)
    {
        return c switch
        {
            'G' => Plant.Grass,
            'C' => Plant.Clover,
            'R' => Plant.Radishes,
            'V' => Plant.Violets,
            _ => throw new ArgumentException("Plant not matchable."),
        };
    }
}