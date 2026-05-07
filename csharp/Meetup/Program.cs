public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private int Month;
    private int Year;
    public Meetup(int month, int year)
    {
        Month = month;
        Year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        return schedule switch
        {
            Schedule.First => FindNth(dayOfWeek, 1),
            Schedule.Second => FindNth(dayOfWeek, 2),
            Schedule.Third => FindNth(dayOfWeek, 3),
            Schedule.Fourth => FindNth(dayOfWeek, 4),
            Schedule.Teenth => FindTeenth(dayOfWeek),
            Schedule.Last => FindLast(dayOfWeek),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    public DateTime FindLast(DayOfWeek dayOfWeek)
    {
        DateTime date = new DateTime(Year, Month, DateTime.DaysInMonth(Year, Month));

        while (date.DayOfWeek != dayOfWeek)
        {
            date = date.AddDays(-1);
        }
        return date;
    }

    public DateTime FindNth(DayOfWeek dayOfWeek, int n)
    {
        int counter = 0;
        DateTime date = new DateTime(Year, Month, 1);

        while (counter != n)
        {
            if (date.DayOfWeek == dayOfWeek) counter++;
            if (counter != n) date = date.AddDays(1);
        }
        return date;
    }

    public DateTime FindTeenth(DayOfWeek dayOfWeek)
    {
        DateTime date = new DateTime(Year, Month, 13);

        while (date.DayOfWeek != dayOfWeek)
        {
            date = date.AddDays(1);
        }

        return date;
    }
}