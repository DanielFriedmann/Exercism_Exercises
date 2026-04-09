public class HighScores
{
    private List<int> scores;
    public HighScores(List<int> list)
    {
        scores = list;
    }

    public List<int> Scores() => scores;  

    public int Latest() => scores[^1];    

    public int PersonalBest() => scores.Max();
    

    public List<int> PersonalTopThree()
    {
       return scores.OrderByDescending(x => x)
                    .Take(3)
                    .ToList();
    }
}