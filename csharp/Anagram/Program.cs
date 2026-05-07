public class Anagram
{
    private string BaseWord;
    public Anagram(string baseWord)
    {
        BaseWord = baseWord;
    }

    public bool IsAnagram(string candidate)
    {
        if(BaseWord.Length != candidate.Length || BaseWord.ToLower() == candidate.ToLower()) return false;

        char[] sortedBase = BaseWord.ToLower().OrderBy(c => c).ToArray();
        char[] sortedCandidate = candidate.ToLower().OrderBy(c => c).ToArray();

        return sortedBase.SequenceEqual(sortedCandidate);        

    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        return potentialMatches.Where(match => IsAnagram(match)).ToArray();
    }
}