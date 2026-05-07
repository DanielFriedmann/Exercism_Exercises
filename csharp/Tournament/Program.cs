public static class Tournament
{
    public static void Tally(Stream inStream, Stream outStream)
    {
        Dictionary<string, Team> teams = new Dictionary<string, Team>();

        using StreamReader reader = new StreamReader(inStream);
        using StreamWriter writer = new StreamWriter(outStream);

        string line;

        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(";");

            if (!teams.ContainsKey(parts[0])) teams[parts[0]] = new Team(parts[0]);
            if (!teams.ContainsKey(parts[1])) teams[parts[1]] = new Team(parts[1]);

            switch (parts[2])
            {
                case "win": teams[parts[0]].W++; teams[parts[1]].L++; break;
                case "draw": teams[parts[1]].D++; teams[parts[0]].D++; break;
                case "loss": teams[parts[1]].W++; teams[parts[0]].L++; break;
                default: throw new InvalidOperationException("Wrong game result");
            }

            teams[parts[0]].MP++; teams[parts[1]].MP++;
        }
        List<string> lines = new List<string>
        {
            "Team                           | MP |  W |  D |  L |  P"
        };

        foreach (Team team in teams.Values.OrderByDescending(teams => teams.P).ThenBy(teams => teams.Name))
        {
            lines.Add($"{team.Name,-31}| {team.MP,2} | {team.W,2} | {team.D,2} | {team.L,2} | {team.P,2}");
        }

        writer.Write(string.Join("\n", lines));

    }


}

public class Team
{
    public string Name { get; set; }
    public int MP { get; set; }
    public int W { get; set; }
    public int D { get; set; }
    public int L { get; set; }
    public int P => W * 3 + D;

    public Team(string name)
    {
        Name = name;
    }

}
