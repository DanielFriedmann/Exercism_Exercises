public class GradeSchool
{
    public Dictionary<int, List<string>> grades = new Dictionary<int, List<string>>();
    public HashSet<string> students = new HashSet<string>();
    public bool Add(string student, int grade)
    {
        if (students.Contains(student)) return false;

        students.Add(student);

        if (grades.ContainsKey(grade))
        {
            grades[grade].Add(student);
        }
        else grades.Add(grade, new List<string> { student });

        return true;
    }

    public IEnumerable<string> Roster()
    {
        var roster = new List<string>();

        foreach (var grade in grades.Keys.OrderBy(g => g))
        {
            foreach (string s in grades[grade].OrderBy(name => name))
            {
                roster.Add(s);
            }
        }
        return roster;
    }

    public IEnumerable<string> Grade(int grade)
    {

        if (!grades.ContainsKey(grade))
            return new List<string>();

        return grades[grade].OrderBy(name => name);
    }
}